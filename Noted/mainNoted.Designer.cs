namespace Noted
{
    public partial class Noted
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Noted));
            this.noteBox = new System.Windows.Forms.RichTextBox();
            this.listBoxNotes = new System.Windows.Forms.ListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.textFileName = new System.Windows.Forms.TextBox();
            this.FileName = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // noteBox
            // 
            this.noteBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteBox.BackColor = System.Drawing.SystemColors.Window;
            this.noteBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.noteBox.Location = new System.Drawing.Point(12, 141);
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(636, 188);
            this.noteBox.TabIndex = 4;
            this.noteBox.Text = "";
            // 
            // listBoxNotes
            // 
            this.listBoxNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxNotes.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxNotes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxNotes.FormattingEnabled = true;
            this.listBoxNotes.ItemHeight = 15;
            this.listBoxNotes.Location = new System.Drawing.Point(394, 11);
            this.listBoxNotes.Name = "listBoxNotes";
            this.listBoxNotes.Size = new System.Drawing.Size(254, 124);
            this.listBoxNotes.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.Window;
            this.saveButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.saveButton.Location = new System.Drawing.Point(12, 11);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(148, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // textFileName
            // 
            this.textFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textFileName.BackColor = System.Drawing.SystemColors.Window;
            this.textFileName.Location = new System.Drawing.Point(12, 112);
            this.textFileName.Name = "textFileName";
            this.textFileName.Size = new System.Drawing.Size(376, 23);
            this.textFileName.TabIndex = 5;
            // 
            // FileName
            // 
            this.FileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FileName.AutoSize = true;
            this.FileName.Location = new System.Drawing.Point(12, 94);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(60, 15);
            this.FileName.TabIndex = 6;
            this.FileName.Text = "File Name";
            // 
            // Noted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(660, 341);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.textFileName);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.listBoxNotes);
            this.Controls.Add(this.noteBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Noted";
            this.Text = "Noted";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public RichTextBox noteBox;
        public ListBox listBoxNotes;
        public Button saveButton;
        public TextBox textFileName;
        public Label FileName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}