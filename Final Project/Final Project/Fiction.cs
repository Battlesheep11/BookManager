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

namespace WindowsFormsApp1
{
    public partial class FictionSelector : Form
    {
        public string genretext;
        public string agetext;
        public Fiction tempfic;
        public FictionSelector(Fiction tempbook)
        {
            InitializeComponent();
            tempfic = tempbook;
        }

        private void FictionSelector_Load(object sender, EventArgs e)
        {
            genretext = string.Empty;
            agetext = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (agetext ==string.Empty || genretext== string.Empty || txtSynposis.Text== string.Empty)
            {
                DialogResult response = MessageBox.Show("Warning!:\n one or more fields are empty, continue?", "Confirmed", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    editsource();
                }
                if (response == DialogResult.No)
                {
                    MessageBox.Show("Please fill out all options.");
                }
            }
            else
            {
                editsource();
            }
          
        }
        private void editsource()
        {
            if (agetext == string.Empty)
            {
                tempfic.AgeGroup = "Unknown";
            }
            else
            {
                tempfic.AgeGroup = agetext;
            }
            if (genretext == string.Empty)
            {
                tempfic.Genre = "Unknown";
            }
            else
            {
                tempfic.Genre = genretext;
            }
            if (txtSynposis.Text == string.Empty)
            {
                tempfic.Synopsis = "Unknown";
            }
            else
            {
                tempfic.Synopsis = txtSynposis.Text;
            }
            this.Close();
        }

        private void AgeGroup_MouseDown(object sender, MouseEventArgs e)
        {
            int clickedIndex = AgeGroup.IndexFromPoint(e.Location);
            if (clickedIndex != -1)
            {
                AgeGroup.SetItemChecked(clickedIndex, !AgeGroup.GetItemChecked(clickedIndex));
                for (int i = 0; i < AgeGroup.Items.Count; i++)
                {
                    if (i != clickedIndex)
                    {
                        AgeGroup.SetItemChecked(i, false);
                    }
                }
                if (AgeGroup.GetItemChecked(clickedIndex) == true)
                    agetext = AgeGroup.GetItemText(AgeGroup.Items[clickedIndex]);
                else 
                {
                    agetext = string.Empty;
                }
            }
        }

        private void GenreGroup_MouseDown(object sender, MouseEventArgs e)
        {
            int clickedIndex = GenreGroup.IndexFromPoint(e.Location);
            if (clickedIndex != -1)
            {
                GenreGroup.SetItemChecked(clickedIndex, !GenreGroup.GetItemChecked(clickedIndex));
                for (int i = 0; i < GenreGroup.Items.Count; i++)
                {
                    if (i != clickedIndex)
                    {
                        GenreGroup.SetItemChecked(i, false);
                    }
                }
                if (GenreGroup.GetItemChecked(clickedIndex) == true)
                    genretext = GenreGroup.GetItemText(GenreGroup.Items[clickedIndex]);
                else
                {
                    genretext = null;
                }
            }
        }
    }
}
