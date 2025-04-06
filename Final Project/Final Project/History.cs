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

namespace history_books
{
    public partial class HistorySelector : Form
    {
        public History instanceh;
        public string histype;
        public int year;
        public HistorySelector(History toedit)
        {
            InitializeComponent();
            instanceh = toedit;
            histype = string.Empty;
            year = 0;
        }


        private void typeHistory_MouseDown(object sender, MouseEventArgs e)
        {
            int clickedIndex = typeHistory.IndexFromPoint(e.Location);
            if (clickedIndex != -1)
            {
                typeHistory.SetItemChecked(clickedIndex, !typeHistory.GetItemChecked(clickedIndex));
                for (int i = 0; i < typeHistory.Items.Count; i++)
                {
                    if (i != clickedIndex)
                    {
                        typeHistory.SetItemChecked(i, false);
                    }
                }
                if (typeHistory.GetItemChecked(clickedIndex) == true)
                    histype = typeHistory.GetItemText(typeHistory.Items[clickedIndex]);
            }
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
            if (year > DateTime.Now.Year)
            {
                MessageBox.Show("Please input a valid year");
                return;
            }
            if (txtSynopsis.Text == string.Empty || txtYear.Text == string.Empty || histype == string.Empty) 
            {
                DialogResult response = MessageBox.Show("Warning!:\n one or more fields are empty, continue?", "Confirmed", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    editsource();
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
            if (histype == string.Empty)
            {
                instanceh.Subject = "Unknown";
            }
            else
            {
                instanceh.Subject = histype;
            }
            instanceh.YearPublished = year;
            if (txtSynopsis.Text == string.Empty)
            {
                instanceh.Summary = "Unknown";
            }
            else
            {
                instanceh.Summary = txtSynopsis.Text;
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

        private void HistorySelector_Load(object sender, EventArgs e)
        {

        }
    }
}
