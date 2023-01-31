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
            this.noteBox = new System.Windows.Forms.RichTextBox();
            this.listBoxNotes = new System.Windows.Forms.ListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.textFileName = new System.Windows.Forms.TextBox();
            this.FileName = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(12, 111);
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(502, 155);
            this.noteBox.TabIndex = 4;
            this.noteBox.Text = "";
            // 
            // listBoxNotes
            // 
            this.listBoxNotes.FormattingEnabled = true;
            this.listBoxNotes.ItemHeight = 15;
            this.listBoxNotes.Location = new System.Drawing.Point(394, 11);
            this.listBoxNotes.Name = "listBoxNotes";
            this.listBoxNotes.Size = new System.Drawing.Size(120, 94);
            this.listBoxNotes.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 11);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(93, 11);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // textFileName
            // 
            this.textFileName.Location = new System.Drawing.Point(12, 82);
            this.textFileName.Name = "textFileName";
            this.textFileName.Size = new System.Drawing.Size(376, 23);
            this.textFileName.TabIndex = 5;
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Location = new System.Drawing.Point(12, 64);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(60, 15);
            this.FileName.TabIndex = 6;
            this.FileName.Text = "File Name";
            // 
            // Noted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 278);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.textFileName);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.listBoxNotes);
            this.Controls.Add(this.noteBox);
            this.Name = "Noted";
            this.Text = "Noted";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public RichTextBox noteBox;
        public ListBox listBoxNotes;
        public Button saveButton;
        public Button loadButton;
        public TextBox textFileName;
        public Label FileName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}