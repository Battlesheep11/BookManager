using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class DisplayForm : Form
    {
        public Image Cover;
        public DisplayForm(Fiction ficdisplay)
        {
            InitializeComponent();
            Cover = ficdisplay.CoverImage;
            lbltype.Text = "Category: \n" + ficdisplay.TypeOfBook;
            lblTitle.Text = "Book Title: \n" + ficdisplay.Title;
            lblAuthor.Text = "Book Author: \n" + ficdisplay.Author;
            lblisbn.Text = "Unique ISBN: \n" + ficdisplay.ISBN.ToString();
            lblvar1.Text = "Book Genre: \n" + ficdisplay.Genre;
            lblvar2.Text = "Reccomended Age: \n" + ficdisplay.AgeGroup;
            lblvar3.Text = "Synopsis: \n" + ficdisplay.Synopsis;
        }
        public DisplayForm(History hisdisplay)
        {
            InitializeComponent();
            Cover = hisdisplay.CoverImage;
            lbltype.Text = "Category: \n" + hisdisplay.TypeOfBook;
            lblTitle.Text = "Book Title: \n" + hisdisplay.Title;
            lblAuthor.Text = "Book Author: \n" + hisdisplay.Author;
            lblisbn.Text = "Unique ISBN: \n" + hisdisplay.ISBN.ToString();
            lblvar1.Text = "Publishing Year: \n" + hisdisplay.YearPublished;
            lblvar2.Text = "Historical Subject: \n" + hisdisplay.Subject;
            lblvar3.Text = "Summary: \n" + hisdisplay.Summary;
        }
        public DisplayForm(StudyBook studydisplay)
        {
            InitializeComponent();
            Cover = studydisplay.CoverImage;
            lbltype.Text = "Category: \n" + studydisplay.TypeOfBook;
            lblTitle.Text = "Book Title: \n" + studydisplay.Title;
            lblAuthor.Text = "Book Author: \n" + studydisplay.Author;
            lblisbn.Text = "Unique ISBN: \n" + studydisplay.ISBN.ToString();
            lblvar1.Text = "Publishing Year: \n" + studydisplay.YearPublished;
            lblvar2.Text = "Class: \n" + studydisplay.ClassName;
            lblvar3.Text = "Covered Subjects: \n" + studydisplay.SubjectsCovered;
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {        
            bookCover.Image = Cover;
            bookCover.SizeMode = PictureBoxSizeMode.Zoom;
            bookCover.Refresh();
        }
    }
}
