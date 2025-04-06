
namespace WindowsFormsApp1
{
    partial class FictionSelector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FictionSelector));
            this.GenreGroup = new System.Windows.Forms.CheckedListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.AgeGroup = new System.Windows.Forms.CheckedListBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSynopsis = new System.Windows.Forms.Label();
            this.txtSynposis = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // GenreGroup
            // 
            this.GenreGroup.BackColor = System.Drawing.Color.LightSeaGreen;
            this.GenreGroup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GenreGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreGroup.FormattingEnabled = true;
            this.GenreGroup.Items.AddRange(new object[] {
            "Classic",
            "Tragedy",
            "Science fiction",
            "Fantasy",
            "Action",
            "Adventure",
            "Crime",
            "Mystery",
            "Romance",
            "Humor",
            "Horror",
            "Comics"});
            this.GenreGroup.Location = new System.Drawing.Point(63, 27);
            this.GenreGroup.Margin = new System.Windows.Forms.Padding(2);
            this.GenreGroup.Name = "GenreGroup";
            this.GenreGroup.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.GenreGroup.Size = new System.Drawing.Size(140, 264);
            this.GenreGroup.TabIndex = 0;
            this.GenreGroup.Tag = "GenreGroup";
            this.GenreGroup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GenreGroup_MouseDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(429, 83);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 48);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Tag = "btnAdd";
            this.btnAdd.Text = "Finalize";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AgeGroup
            // 
            this.AgeGroup.BackColor = System.Drawing.Color.LightSeaGreen;
            this.AgeGroup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AgeGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeGroup.FormattingEnabled = true;
            this.AgeGroup.Items.AddRange(new object[] {
            "5-10",
            "10-15",
            "15-20",
            "20+"});
            this.AgeGroup.Location = new System.Drawing.Point(251, 27);
            this.AgeGroup.Margin = new System.Windows.Forms.Padding(2);
            this.AgeGroup.Name = "AgeGroup";
            this.AgeGroup.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.AgeGroup.Size = new System.Drawing.Size(126, 88);
            this.AgeGroup.TabIndex = 3;
            this.AgeGroup.Tag = "AgeGroup";
            this.AgeGroup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AgeGroup_MouseDown);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(62, 14);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Tag = "lblGenre";
            this.lblGenre.Text = "Genre";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(248, 13);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(56, 13);
            this.lblAge.TabIndex = 5;
            this.lblAge.Tag = "lblAge";
            this.lblAge.Text = "Age group";
            // 
            // lblSynopsis
            // 
            this.lblSynopsis.AutoSize = true;
            this.lblSynopsis.Location = new System.Drawing.Point(248, 141);
            this.lblSynopsis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSynopsis.Name = "lblSynopsis";
            this.lblSynopsis.Size = new System.Drawing.Size(49, 13);
            this.lblSynopsis.TabIndex = 6;
            this.lblSynopsis.Tag = "lblSynopsis";
            this.lblSynopsis.Text = "Synopsis";
            // 
            // txtSynposis
            // 
            this.txtSynposis.Location = new System.Drawing.Point(251, 157);
            this.txtSynposis.Name = "txtSynposis";
            this.txtSynposis.Size = new System.Drawing.Size(260, 163);
            this.txtSynposis.TabIndex = 7;
            this.txtSynposis.Tag = "txtSynopsis";
            this.txtSynposis.Text = "";
            // 
            // FictionSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txtSynposis);
            this.Controls.Add(this.lblSynopsis);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.AgeGroup);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.GenreGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FictionSelector";
            this.Text = "Fiction Selector";
            this.Load += new System.EventHandler(this.FictionSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox GenreGroup;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckedListBox AgeGroup;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblSynopsis;
        private System.Windows.Forms.RichTextBox txtSynposis;
    }
}

