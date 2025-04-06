
namespace Final_Project
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.BookPreview = new System.Windows.Forms.PictureBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.lblBookType = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.Button();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.BookType = new System.Windows.Forms.CheckedListBox();
            this.ArchiveView = new System.Windows.Forms.DataGridView();
            this.btnImage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 18);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Tag = "lblTitle";
            this.lblTitle.Text = "Title:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(13, 62);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(51, 18);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Tag = "lblAuthor";
            this.lblAuthor.Text = "Author";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(13, 103);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(42, 18);
            this.lblISBN.TabIndex = 2;
            this.lblISBN.Tag = "lblISBN";
            this.lblISBN.Text = "ISBN";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(16, 29);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(145, 20);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Tag = "txtTitle";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(16, 80);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(145, 20);
            this.txtAuthor.TabIndex = 2;
            this.txtAuthor.Tag = "txtAuthor";
            // 
            // BookPreview
            // 
            this.BookPreview.Location = new System.Drawing.Point(571, 232);
            this.BookPreview.Name = "BookPreview";
            this.BookPreview.Size = new System.Drawing.Size(202, 187);
            this.BookPreview.TabIndex = 7;
            this.BookPreview.TabStop = false;
            this.BookPreview.Tag = "BookPreview";
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreview.Location = new System.Drawing.Point(567, 157);
            this.lblPreview.MaximumSize = new System.Drawing.Size(200, 100);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(177, 20);
            this.lblPreview.TabIndex = 8;
            this.lblPreview.Tag = "lblPreviw";
            this.lblPreview.Text = "Currently Viewing: None";
            // 
            // lblBookType
            // 
            this.lblBookType.AutoSize = true;
            this.lblBookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookType.Location = new System.Drawing.Point(172, 9);
            this.lblBookType.Name = "lblBookType";
            this.lblBookType.Size = new System.Drawing.Size(84, 18);
            this.lblBookType.TabIndex = 10;
            this.lblBookType.Tag = "lblBookType";
            this.lblBookType.Text = "Book Type:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(459, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 47);
            this.btnSave.TabIndex = 5;
            this.btnSave.Tag = "btnSave";
            this.btnSave.Text = "Save All";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(684, 64);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 84);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Tag = "btnDelete";
            this.btnDelete.Text = "Delete Selected Entry";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(571, 64);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 84);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Tag = "btnEdit";
            this.btnEdit.Text = "Edit Selected Entry";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnArchive
            // 
            this.btnArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchive.Location = new System.Drawing.Point(458, 64);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(89, 84);
            this.btnArchive.TabIndex = 8;
            this.btnArchive.Tag = "btnArchive";
            this.btnArchive.Text = "Add To Archive";
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(571, 11);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(88, 47);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Tag = "btnLoad";
            this.btnLoad.Text = "Load From File";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Display
            // 
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.Location = new System.Drawing.Point(684, 11);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(88, 47);
            this.Display.TabIndex = 7;
            this.Display.Tag = "Display";
            this.Display.Text = "Display Information";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(16, 124);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(145, 20);
            this.txtISBN.TabIndex = 3;
            this.txtISBN.Tag = "txtISBN";
            this.txtISBN.TextChanged += new System.EventHandler(this.txtISBN_TextChanged);
            // 
            // BookType
            // 
            this.BookType.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BookType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookType.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookType.FormattingEnabled = true;
            this.BookType.Items.AddRange(new object[] {
            "Fiction",
            "History",
            "Study Book"});
            this.BookType.Location = new System.Drawing.Point(167, 30);
            this.BookType.Name = "BookType";
            this.BookType.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.BookType.Size = new System.Drawing.Size(155, 87);
            this.BookType.TabIndex = 4;
            this.BookType.Tag = "BookType";
            this.BookType.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BookType_MouseDown);
            // 
            // ArchiveView
            // 
            this.ArchiveView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArchiveView.Location = new System.Drawing.Point(16, 157);
            this.ArchiveView.Name = "ArchiveView";
            this.ArchiveView.ReadOnly = true;
            this.ArchiveView.Size = new System.Drawing.Size(531, 262);
            this.ArchiveView.TabIndex = 11;
            this.ArchiveView.Tag = "ArchiveView";
            this.ArchiveView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ArchiveView_CellClick);
            this.ArchiveView.Leave += new System.EventHandler(this.ArchiveView_Leave);
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.Red;
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.Location = new System.Drawing.Point(324, 11);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(121, 137);
            this.btnImage.TabIndex = 12;
            this.btnImage.Tag = "btnImage";
            this.btnImage.Text = "Click To Add Image";
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(167, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "Clear fields";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(792, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.BookType);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblBookType);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.BookPreview);
            this.Controls.Add(this.ArchiveView);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.Text = "Book Manager 3000";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.PictureBox BookPreview;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Label lblBookType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.CheckedListBox BookType;
        private System.Windows.Forms.DataGridView ArchiveView;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button button1;
    }
}