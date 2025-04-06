
namespace Study_book_form
{
    partial class StudySelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudySelector));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.CheckedListBox();
            this.txtSubjects = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(69, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(68, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subjects covered:";
            // 
            // TypeBox
            // 
            this.TypeBox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.TypeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TypeBox.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "Literature",
            "Language",
            "Math",
            "Engineering",
            "Computer Science"});
            this.TypeBox.Location = new System.Drawing.Point(72, 59);
            this.TypeBox.Margin = new System.Windows.Forms.Padding(2);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.TypeBox.Size = new System.Drawing.Size(260, 165);
            this.TypeBox.TabIndex = 4;
            this.TypeBox.Tag = "TypeBox";
            this.TypeBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TypeBox_MouseDown);
            // 
            // txtSubjects
            // 
            this.txtSubjects.Location = new System.Drawing.Point(72, 252);
            this.txtSubjects.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubjects.Name = "txtSubjects";
            this.txtSubjects.Size = new System.Drawing.Size(393, 135);
            this.txtSubjects.TabIndex = 5;
            this.txtSubjects.Tag = "txtSubjects";
            this.txtSubjects.Text = "";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(507, 334);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 48);
            this.button2.TabIndex = 6;
            this.button2.Text = "Finalize ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(333, 33);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(282, 24);
            this.lblYear.TabIndex = 11;
            this.lblYear.Tag = "lblYear";
            this.lblYear.Text = "Please input the publishing year:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(337, 59);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(278, 20);
            this.txtYear.TabIndex = 10;
            this.txtYear.Tag = "txtYear";
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // StudySelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(627, 398);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtSubjects);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudySelector";
            this.Tag = "StudySelector";
            this.Text = "Study Information";
            this.Load += new System.EventHandler(this.StudySelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox TypeBox;
        private System.Windows.Forms.RichTextBox txtSubjects;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
    }
}

