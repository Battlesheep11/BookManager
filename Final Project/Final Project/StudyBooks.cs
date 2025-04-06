using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project;

namespace Study_book_form
{
    public partial class StudySelector : Form
    {
        public StudyBook instances;
        public StudySelector instance;
        public string classname;
        public int year;
        public StudySelector(StudyBook toedit)
        {
            InitializeComponent();
            instances = toedit;
            classname = string.Empty;
            year = 0;
        }
        private void btnFinalize_Click(object sender, EventArgs e)
        {
            try
            {
                year = int.Parse(txtYear.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please input a year.");
                return;
            }
            if (year > DateTime.Now.Year || year < 0)
            {
                MessageBox.Show("Please input a valid year");
                return;
            }
            if (txtSubjects.Text == string.Empty || txtYear.Text == string.Empty || classname == string.Empty)
            {
                DialogResult response = MessageBox.Show("Warning!:\n one or more fields are empty, continue?", "Confirmed", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    editsource();
                    instances.SubjectsCovered = "Unknown";
                    this.Close();
                }
                if (response == DialogResult.No)
                {
                    MessageBox.Show("Please fill out all options.");
                    return;
                }
                MessageBox.Show("Finilization Error\nPlease try again.");
                return;
            }
            else
            {
                editsource();
                this.Close();
            }
        }
        private void editsource()
        {
            if (classname == string.Empty)
            {
                instances.ClassName = "Unknown";
            }
            else
            {
                instances.ClassName = classname;
            }
            instances.YearPublished = year;
            if (txtSubjects.Text == string.Empty)
            {
                instances.SubjectsCovered = "Unknown";
            }
            else
            {
                instances.SubjectsCovered = txtSubjects.Text;
            }
        }
        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;
            if (text.Length > 0 && !char.IsDigit(text.Last()))
            {
                textBox.Text = text.Substring(0, text.Length - 1);
                MessageBox.Show("Please input a valid number");
            }
            if (text.Count(char.IsDigit) > 4)
            {
                textBox.Text = text.Substring(0, text.Length - 1);
                MessageBox.Show("Please input a valid year");
            }
        }
        private void TypeBox_MouseDown(object sender, MouseEventArgs e)
        {
            int clickedIndex = TypeBox.IndexFromPoint(e.Location);
            if (clickedIndex != -1)
            {
                TypeBox.SetItemChecked(clickedIndex, !TypeBox.GetItemChecked(clickedIndex));
                for (int i = 0; i < TypeBox.Items.Count; i++)
                {
                    if (i != clickedIndex)
                    {
                        TypeBox.SetItemChecked(i, false);
                    }
                }
                if (TypeBox.GetItemChecked(clickedIndex) == true)
                    classname = TypeBox.GetItemText(TypeBox.Items[clickedIndex]);
                else
                {
                    classname = string.Empty;
                }
            }
        }

        private void StudySelector_Load(object sender, EventArgs e)
        {

        }
    }
}
