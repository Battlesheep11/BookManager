using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace Final_Project
{
    public partial class MainScreen : Form
    {
        public bool imgtest = false;
        public Library book_details = new Library();
        public static MainScreen instance;
        public string coverimg;
        public string CheckedText;
        public int Gindex;
        public MainScreen()
        {
            InitializeComponent();
            instance = this;
            Gindex = 1;
            BookPreview.Image = Properties.Resources.DefaultBookCover;
            BookPreview.SizeMode = PictureBoxSizeMode.Zoom;
            BookPreview.Refresh();
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "SandI")
            {
                Secret shh = new Secret();
                shh.ShowDialog();
            }
            else
            {
                string title = txtTitle.Text;
                string author = txtAuthor.Text;
                string type = string.Empty;
                int isbn = 0;
                int isbnResponse = ValidateISBN(txtISBN.Text);

                if (CheckedText != null)
                {
                    type = CheckedText;
                }
                else
                {
                    MessageBox.Show("ERROR:\nNo booktype selected.\nPlease select a book type to be added.");
                    return;
                }

                if (isbnResponse == 2)
                {
                    isbn = int.Parse(txtISBN.Text);
                }
                else if (isbnResponse == 1)
                {
                    MessageBox.Show("ERROR:\nDuplicate ISBN number. Please input a unique ISBN.");
                    return;
                }
                else
                {
                    MessageBox.Show("ERROR:\nInvalid ISBN value detected.\nPlease input a valid 8-digit number.");
                    return;
                }
                if (!imgtest)
                {
                    MessageBox.Show("ERROR:\nNo Image Selected.\n Please add an Image to Continue");
                    return;
                }
                else
                {
                    Book bookDisplay = new Book(Gindex++, title, author, isbn, type);
                    bookDisplay.CoverImage = Image.FromFile(coverimg);
                    coverimg = null;
                    bookDisplay.ArchiveBook(book_details);
                    ArchiveView.DataSource = null;
                    ArchiveView.DataSource = book_details.books;
                    ArchiveView.Refresh();
                    clearfields();
                    BookTypeInfo(bookDisplay);
                }
            }
        }
        
        private void clearfields()
        {
            txtTitle.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtISBN.Text = string.Empty;
            for (int i = 0; i < BookType.Items.Count; i++)
            {
                    BookType.SetItemChecked(i, false);
            }
            imgtest = false;
            ArchiveView.CurrentCell = null;
            btnImage.BackColor = Color.Red;
            btnImage.Text = "Please add a Picutre";
            BookPreview.Image = Properties.Resources.DefaultBookCover;
            BookPreview.SizeMode = PictureBoxSizeMode.Zoom;
            BookPreview.Refresh();
        }
        private void BookTypeInfo(Book basebook)
        {
            string type = basebook.TypeOfBook;
            if (type == "Fiction")
            {
                Fiction newBook = new Fiction(Gindex, basebook.Title, basebook.Author, basebook.ISBN, basebook.TypeOfBook);
                newBook.editimage(basebook.CoverImage);
                newBook.ArchiveBook(book_details);
            }
            if (type == "History")
            {
                History newBook = new History(Gindex, basebook.Title, basebook.Author, basebook.ISBN, basebook.TypeOfBook);
                newBook.editimage(basebook.CoverImage);
                newBook.ArchiveBook(book_details);
            }
            if (type == "Study Book")
            {
                StudyBook newBook = new StudyBook(Gindex, basebook.Title, basebook.Author, basebook.ISBN, basebook.TypeOfBook);
                newBook.editimage(basebook.CoverImage);
                newBook.ArchiveBook(book_details);
            }
        }
        private int ValidateISBN(string isbn)
        {
            if (book_details != null)
                if (isbn.Length == 8 && int.Parse(isbn) > 0)
                {
                    foreach (Book book in book_details.books)
                    {
                        string currISBN = book.ISBN.ToString();
                        if (isbn == currISBN)
                            return 1;
                    }
                    return 2;
                }
                else return 3;
            return 2;
        }

        public void MainScreen_Load(object sender, EventArgs e)
        {
            ArchiveView.AutoGenerateColumns = false;
            DataGridViewColumn indexColumn = new DataGridViewTextBoxColumn();
            indexColumn.DataPropertyName = "Index";
            indexColumn.HeaderText = "Index";
            ArchiveView.Columns.Add(indexColumn);

            DataGridViewColumn titleColumn = new DataGridViewTextBoxColumn();
            titleColumn.DataPropertyName = "Title";
            titleColumn.HeaderText = "Title";
            ArchiveView.Columns.Add(titleColumn);

            DataGridViewColumn authorColumn = new DataGridViewTextBoxColumn();
            authorColumn.DataPropertyName = "Author";
            authorColumn.HeaderText = "Author";
            ArchiveView.Columns.Add(authorColumn);

            DataGridViewColumn isbnColumn = new DataGridViewTextBoxColumn();
            isbnColumn.DataPropertyName = "ISBN";
            isbnColumn.HeaderText = "ISBN";
            ArchiveView.Columns.Add(isbnColumn);

            DataGridViewColumn typeOfBookColumn = new DataGridViewTextBoxColumn();
            typeOfBookColumn.DataPropertyName = "TypeOfBook";
            typeOfBookColumn.HeaderText = "Book Type";
            ArchiveView.Columns.Add(typeOfBookColumn);
        }

        private void Display_Click(object sender, EventArgs e)
        {
            if (ArchiveView.CurrentRow != null && ArchiveView.CurrentRow.Index >= 0)
            {
                Book basebook = book_details.books[ArchiveView.CurrentRow.Index];
                try
                {
                    bookgetter(basebook).displaybook();
                }
                catch (Exception)
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select a book to Display.");
            }
            clearfields();
        }

        private void BookType_MouseDown(object sender, MouseEventArgs e)
        {
            int clickedIndex = BookType.IndexFromPoint(e.Location);
            if (clickedIndex != -1)
            {
                BookType.SetItemChecked(clickedIndex, !BookType.GetItemChecked(clickedIndex));
                for (int i = 0; i < BookType.Items.Count; i++)
                {
                    if (i != clickedIndex)
                    {
                        BookType.SetItemChecked(i, false);
                    }
                }
                if (BookType.GetItemChecked(clickedIndex) == true)
                    CheckedText = BookType.GetItemText(BookType.Items[clickedIndex]);
                else
                {
                    CheckedText = null;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            {
                if (ArchiveView.CurrentRow != null && ArchiveView.CurrentRow.Index >= 0)
                {
                    int rowIndex = ArchiveView.CurrentRow.Index;
                    Book source = book_details.books[rowIndex];
                    book_details.removefromlibrary(source);
                    book_details.resetindex();
                    ArchiveView.DataSource = null;
                    ArchiveView.DataSource = book_details.books;
                    ArchiveView.Refresh();
                }
                else
                {
                    MessageBox.Show("Please select a book to delete.");
                }
                clearfields();
            }
        }

        private void ArchiveView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ArchiveView.Rows.Count && book_details.books.Count > 0)
            {
                {
                    int selectedIndex = e.RowIndex;
                    Book bookDisplay = book_details.books[selectedIndex];
                    txtTitle.Text = bookDisplay.Title;
                    txtAuthor.Text = bookDisplay.Author;
                    txtISBN.Text = bookDisplay.ISBN.ToString();

                    for (int i = 0; i < BookType.Items.Count; i++)
                    {
                        if (BookType.GetItemText(BookType.Items[i]) == bookDisplay.TypeOfBook)
                        {
                            BookType.SetItemChecked(i, true);
                        }
                        else
                        {
                            BookType.SetItemChecked(i, false);
                        }
                    }
                    BookPreview.Image = bookDisplay.CoverImage;
                    BookPreview.SizeMode = PictureBoxSizeMode.Zoom;
                    lblPreview.Text = "Currently Viewing: " + bookDisplay.Title;
                    btnImage.Text = "Click to change the Image";
                    btnImage.BackColor = Color.White;
                    BookPreview.Refresh();
                }
            }
        }
        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ArchiveView.CurrentRow != null)
            {
                bool edit = true;
                try
                {
                    BookType.CheckedItems[0].ToString();
                }
                catch
                {
                    MessageBox.Show("No Booktype Selected.");
                    return;
                }
                string selectedtype = BookType.CheckedItems[0].ToString();
                int currindex = ArchiveView.CurrentRow.Index;
                Book bookDisplay = book_details.books[currindex];
                Book prevbook = new Book(bookDisplay.Index, bookDisplay.Title, bookDisplay.Author, bookDisplay.ISBN, bookDisplay.TypeOfBook);
                bookDisplay.Title = txtTitle.Text;
                bookDisplay.Author = txtAuthor.Text;
                if (int.Parse(txtISBN.Text) != bookDisplay.ISBN)
                {
                    int isbnresponse = ValidateISBN(txtISBN.Text);
                    if (isbnresponse == 2)
                    {
                        bookDisplay.ISBN = int.Parse(txtISBN.Text);
                        changedisbn(prevbook.ISBN, bookDisplay);
                    }
                    else if (isbnresponse == 1)
                    {
                        MessageBox.Show("ERROR:\n Duplciate ISBN number, please input\n a unique ISBN.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("ERROR:\nInvalid ISBN value detected.\nPlease input a valid 8 digit number.");
                        return;
                    }
                }
                if (prevbook.TypeOfBook != selectedtype)
                {
                    bookDisplay.TypeOfBook=selectedtype;
                    typechange(prevbook, bookDisplay);
                    edit = false;
                }
                if (edit) 
                {
                    editbook(book_details.books[currindex]);
                }
                ArchiveView.Refresh();
                clearfields();
            }
            else
            {
                MessageBox.Show("Please select a book to edit.");
            }
        }

        private void typechange(Book prev, Book curr)
        {
            book_details.removefromlibrary(prev, false);
            BookTypeInfo(curr);
        }
        private void changedisbn(int previsbn,Book source) 
        {
             if(source.TypeOfBook == "Fiction")
             {
               Fiction temp = book_details.fictions.First(f => f.ISBN == previsbn);
                temp.ISBN = source.ISBN;
             }
            if (source.TypeOfBook == "History")
            {
                History temp = book_details.histories.First(f => f.ISBN == previsbn);
                temp.ISBN = source.ISBN;
            }
            if (source.TypeOfBook == "Study Book")
            {
                StudyBook temp = book_details.studies.First(f => f.ISBN == previsbn);
                temp.ISBN = source.ISBN;
            }
        }
        private void editbook(Book source)
        {
            try
            {
                bookgetter(source).EditArchive();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.jpeg)|*.jpg;*.png;*.jpeg";
            openFileDialog.Title = "Select an Image";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                if (ArchiveView.CurrentRow != null)
                {
                    Book bookDisplay = book_details.books[ArchiveView.CurrentRow.Index];
                    bookDisplay.CoverImage = Image.FromFile(imagePath);
                    try
                    {
                        bookgetter(bookDisplay).editimage(Image.FromFile(imagePath));
                        lblPreview.Text = "Preview: " + bookDisplay.Title;
                        BookPreview.Image = bookDisplay.CoverImage;
                        BookPreview.SizeMode = PictureBoxSizeMode.Zoom;
                        btnImage.BackColor = Color.Green;
                        btnImage.Text = "Image Changed.";
                        BookPreview.Refresh();
                    }
                    catch(Exception)
                    {
                        return;
                    }
                }
                else
                {
                    setimage(imagePath);
                }
            }
        }
        private void setimage(string path) 
        {
            coverimg = path;
            BookPreview.Image = Image.FromFile(path);
            BookPreview.SizeMode = PictureBoxSizeMode.Zoom;
            imgtest = true;
            btnImage.BackColor = Color.Green;
            btnImage.Text = "Image Added.";
        }
        private Book bookgetter(Book toget)
        {
            string type = toget.TypeOfBook;
            try
            {
                if (type == "Fiction")
                {
                    return book_details.fictions.First(f => f.ISBN == toget.ISBN);
                }
                if (type == "History")
                {
                    return book_details.histories.First(h => h.ISBN == toget.ISBN);
                }
                if (type == "Study Book")
                {
                    return book_details.studies.First(s => s.ISBN == toget.ISBN);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: \n could not get Book Type.");
            }
            return null;
        }
        public static string selectfilelocationload()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Serialized Files (*.DAT)|*.DAT";
            openFileDialog.Title = "Select a Serialized File to Load";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }

            return string.Empty; 
        }
        public static string selectfilelocationsave()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Serialized Files (*.DAT)|*.DAT";
            saveFileDialog.Title = "Choose a Location to save the Serialized File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }

            return string.Empty; 
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string temppath = selectfilelocationsave();
            if (temppath == string.Empty)
            {
                MessageBox.Show("Save Error, Please Try Again.");
                return;
            }
            else
            {
                book_details.SaveLibrary(temppath);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string temppath = selectfilelocationload();
            if (temppath == string.Empty)
            {
                MessageBox.Show("Load Error, Please Try Again.");
                return;
            }
            else
            {
                if (Library.LoadLibrary(temppath,false) == null)
                {
                    MessageBox.Show("Loaded Library is empty.\n Please select a different Library.");
                    return;
                }
                book_details = Library.LoadLibrary(temppath);
                book_details.resetindex();
                ArchiveView.DataSource = null;
                ArchiveView.DataSource = book_details.books;
                ArchiveView.Refresh();
                BookPreview.Refresh();
            }
        }

        private void ArchiveView_Leave(object sender, EventArgs e)
        {
            imgtest = false;
            btnImage.BackColor = Color.Red;
            btnImage.Text = "Clear fields to add new entires.";
            lblPreview.Text = "Currently Viewing: None";
            BookPreview.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArchiveView.CurrentCell = null;
            clearfields();
        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {
                TextBox textBox = (TextBox)sender;
                string text = textBox.Text;
                if (text.Length > 0 && !char.IsDigit(text.Last()))
                {
                    textBox.Text = text.Substring(0, text.Length - 1);
                    MessageBox.Show("Please input a valid number");
                }
                if (text.Count(char.IsDigit) > 8)
                {
                    textBox.Text = text.Substring(0, text.Length - 1);
                    MessageBox.Show("ISBN must be 8 digits.");
                }
        }
    }
}
