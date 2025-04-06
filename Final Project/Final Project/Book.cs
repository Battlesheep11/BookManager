using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using WindowsFormsApp1;
using history_books;
using Microsoft.VisualBasic;
using Study_book_form;

namespace Final_Project
{
    [Serializable]
    public class Book
    {
        public int Index { get; set; }
        public string TypeOfBook { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }
        public Image CoverImage { get; set; }

        public Book(int dindex = 0,string title ="Unknown", string author = "Unknown", int isbn =-1,string tob = "Fiction")
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Index = dindex;
            TypeOfBook = tob;
            CoverImage = Properties.Resources.DefaultBookCover;
        }
        public void editimage(Image newimage) 
        {
            this.CoverImage = newimage;
        }
        public virtual void displaybook()
        {

        }
        public virtual void EditArchive() 
        {
        
        }
        public virtual void ArchiveBook(Library bookDetails)
        {
            bookDetails.books.Add(this);
        }
    }
    [Serializable]
    public class Fiction : Book
    {
        public string Synopsis { get; set; }
        public string Genre { get; set; }
        public string AgeGroup { get; set; }

        public Fiction(int dindex, string title, string author, int isbn, string tob, string genre = "Unknown", string synopsis = "Unknown", string agegroup = "Unknown") 
            : base(dindex, title, author, isbn, tob)
        {
            Genre = genre; 
            Synopsis = synopsis;
            AgeGroup = agegroup;
        }
        public override void EditArchive()
        {
            FictionSelector formselector = new FictionSelector(this);
            formselector.ShowDialog();
        }

        public override void ArchiveBook(Library bookDetails)
        {
            FictionSelector formselector = new FictionSelector(this);
            formselector.ShowDialog();
            bookDetails.fictions.Add(this);
        }
        public override void displaybook()
        {
            DisplayForm info = new DisplayForm(this);
            info.ShowDialog();
        }
    }

    [Serializable]
    public abstract class NonFiction : Book
    {
        public int YearPublished { get; set; }
        public NonFiction(int dindex, string title, string author, int isbn, string tob, int yearpublished = 1000)
            : base(dindex, title, author, isbn, tob)
        { 
            YearPublished = yearpublished;
        }
    }

    [Serializable]
    public class History : NonFiction
    {
        public string Subject { get; set; }
        public string Summary { get; set; }
        public History(int dindex, string title, string author, int isbn, string tob,int yearpublished = 0000, string subject = "Unknown", string summary = "Unknown")
            : base(dindex, title, author, isbn, tob, yearpublished)
        {
            Subject = subject;
            Summary = summary;
        }
        public override void EditArchive()
        {
            HistorySelector formselector = new HistorySelector(this);
            formselector.ShowDialog();
        }

        public override void ArchiveBook(Library bookDetails)
        {
            HistorySelector formselector = new HistorySelector(this);
            formselector.ShowDialog();
            bookDetails.histories.Add(this);
        }
        public override void displaybook()
        {
            DisplayForm info = new DisplayForm(this);
            info.ShowDialog();
        }
    }

    [Serializable]
    public class StudyBook : NonFiction
    {
        public string ClassName { get; set; }
        public string SubjectsCovered { get; set; }
        public StudyBook(int dindex, string title, string author, int isbn, string tob,int yearpublished = 0000, string classname="Unknown", string subjectscovered ="Unknown")
             : base(dindex, title, author, isbn, tob, yearpublished)
        {
            ClassName = classname;
            SubjectsCovered = subjectscovered;
        }
        public override void EditArchive()
        {
            StudySelector formselector = new StudySelector(this);
            formselector.ShowDialog();
        }

        public override void ArchiveBook(Library bookDetails)
        {
            StudySelector formselector = new StudySelector(this);
            formselector.ShowDialog();
            bookDetails.studies.Add(this);
        }
        public override void displaybook()
        {
            DisplayForm info = new DisplayForm(this);
            info.ShowDialog();
        }
    }
    [Serializable]
    public class Library
    {
        public List<Book> books { get; set; }
        public List<Fiction> fictions { get; set; }
        public List<History> histories { get; set; }
        public List<StudyBook> studies { get; set; }
        public Library()
        {
            books = new List<Book>();
            fictions = new List<Fiction>();
            histories = new List<History>();
            studies = new List<StudyBook>();
        }

        public void resetindex()
        {
            MainScreen.instance.Gindex = 1;
            foreach (Book book in books)
            {
                book.Index = MainScreen.instance.Gindex++;
            }
        }
        public void removefromlibrary (Book source,bool removesource = true)
        {
            string type = source.TypeOfBook;
            if (type == "Fiction")
            {
                int toremove = this.fictions.FindIndex(f => f.ISBN == source.ISBN);
                this.fictions.RemoveAt(toremove);
            }
            if (type == "History")
            {
                int toremove = this.histories.FindIndex(h => h.ISBN == source.ISBN);
                this.histories.RemoveAt(toremove);
            }
            if (type == "Study Book")
            {
                int toremove = this.studies.FindIndex(h => h.ISBN == source.ISBN);
                this.studies.RemoveAt(toremove);
            }
            if (removesource)
            {
                this.books.RemoveAt(source.Index - 1);
            }
        }
        public void SaveLibrary(string filePath)
        {
            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, this);
                }
                MessageBox.Show("Library saved successfully.");
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurred while saving the library.\nPlease try again.");
            }
        }

        public static Library LoadLibrary(string filePath,bool response = true)
        {
            Library library = null;
            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    library = (Library)formatter.Deserialize(fileStream);
                }
                if (response)
                {
                    MessageBox.Show("Library loaded successfully.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurred while loading the library\nPlease try again.");
            }
            return library;
        }
    }

   
}


