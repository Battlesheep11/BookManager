
namespace history_books
{
    partial class HistorySelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorySelector));
            this.typeHistory = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSynopsis = new System.Windows.Forms.RichTextBox();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // typeHistory
            // 
            this.typeHistory.BackColor = System.Drawing.Color.LightSeaGreen;
            this.typeHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.typeHistory.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeHistory.FormattingEnabled = true;
            this.typeHistory.Items.AddRange(new object[] {
            "Political History",
            "Social History",
            "Economic History",
            "Cultural History"});
            this.typeHistory.Location = new System.Drawing.Point(48, 76);
            this.typeHistory.Margin = new System.Windows.Forms.Padding(2);
            this.typeHistory.Name = "typeHistory";
            this.typeHistory.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.typeHistory.Size = new System.Drawing.Size(249, 132);
            this.typeHistory.TabIndex = 0;
            this.typeHistory.Tag = "typeHistory";
            this.typeHistory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.typeHistory_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(44, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type of history";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(44, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Summary";
            // 
            // txtSynopsis
            // 
            this.txtSynopsis.Location = new System.Drawing.Point(46, 241);
            this.txtSynopsis.Margin = new System.Windows.Forms.Padding(2);
            this.txtSynopsis.Name = "txtSynopsis";
            this.txtSynopsis.Size = new System.Drawing.Size(334, 148);
            this.txtSynopsis.TabIndex = 4;
            this.txtSynopsis.Tag = "txtSynopsis";
            this.txtSynopsis.Text = "";
            // 
            // btnFinalize
            // 
            this.btnFinalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnFinalize.Location = new System.Drawing.Point(518, 340);
            this.btnFinalize.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(89, 48);
            this.btnFinalize.TabIndex = 7;
            this.btnFinalize.Tag = "btnFinalize";
            this.btnFinalize.Text = "FInalize";
            this.btnFinalize.UseVisualStyleBackColor = true;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(298, 76);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(271, 20);
            this.txtYear.TabIndex = 8;
            this.txtYear.Tag = "txtYear";
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(294, 50);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(275, 24);
            this.lblYear.TabIndex = 9;
            this.lblYear.Tag = "lblYear";
            this.lblYear.Text = "Please Input the Publising Year:";
            // 
            // HistorySelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(627, 398);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.btnFinalize);
            this.Controls.Add(this.txtSynopsis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeHistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HistorySelector";
            this.Tag = "HistorySelector";
            this.Text = "History Information";
            this.Load += new System.EventHandler(this.HistorySelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox typeHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtSynopsis;
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
    }
}

