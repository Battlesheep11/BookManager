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
    public partial class Secret : Form
    {
        public Secret instance;
        private bool mousedown = false;
        private Point dragstart;

        public Secret()
        {
            InitializeComponent();
            instance = this;
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousedown = true;
                dragstart = new Point(e.X, e.Y);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                int newX = pictureBox1.Left + e.X - dragstart.X;
                int newY = pictureBox1.Top + e.Y - dragstart.Y;
                newX = Math.Max(newX, 0);
                newY = Math.Max(newY, 0);
                newX = Math.Min(newX, ClientSize.Width - pictureBox1.Width);
                newY = Math.Min(newY, ClientSize.Height - pictureBox1.Height);
                pictureBox1.Location = new Point(newX, newY);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousedown = false;
            }
        }
    }
}
