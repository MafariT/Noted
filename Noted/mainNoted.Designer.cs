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
            this.deleteButton = new System.Windows.Forms.Button();
            this.renameButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBold = new System.Windows.Forms.Button();
            this.italicButton = new System.Windows.Forms.Button();
            this.underlineButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noteBox
            // 
            this.noteBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteBox.BackColor = System.Drawing.SystemColors.Window;
            this.noteBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.noteBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.noteBox.Location = new System.Drawing.Point(12, 99);
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(611, 291);
            this.noteBox.TabIndex = 4;
            this.noteBox.Text = "";
            // 
            // listBoxNotes
            // 
            this.listBoxNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxNotes.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxNotes.ColumnWidth = 100;
            this.listBoxNotes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxNotes.FormattingEnabled = true;
            this.listBoxNotes.HorizontalScrollbar = true;
            this.listBoxNotes.ItemHeight = 15;
            this.listBoxNotes.Location = new System.Drawing.Point(629, 11);
            this.listBoxNotes.Name = "listBoxNotes";
            this.listBoxNotes.Size = new System.Drawing.Size(254, 379);
            this.listBoxNotes.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.Window;
            this.saveButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.saveButton.Location = new System.Drawing.Point(12, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(148, 25);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // textFileName
            // 
            this.textFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFileName.BackColor = System.Drawing.SystemColors.Window;
            this.textFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textFileName.Location = new System.Drawing.Point(12, 67);
            this.textFileName.Name = "textFileName";
            this.textFileName.Size = new System.Drawing.Size(611, 23);
            this.textFileName.TabIndex = 5;
            // 
            // FileName
            // 
            this.FileName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileName.AutoSize = true;
            this.FileName.Location = new System.Drawing.Point(12, 49);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(60, 15);
            this.FileName.TabIndex = 6;
            this.FileName.Text = "File Name";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.Window;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.deleteButton.Location = new System.Drawing.Point(474, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(148, 25);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // renameButton
            // 
            this.renameButton.BackColor = System.Drawing.SystemColors.Window;
            this.renameButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.renameButton.Location = new System.Drawing.Point(166, 12);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(148, 25);
            this.renameButton.TabIndex = 8;
            this.renameButton.Text = "Rename";
            this.renameButton.UseVisualStyleBackColor = false;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(320, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.newButton_Click);
            // 
            // buttonBold
            // 
            this.buttonBold.BackColor = System.Drawing.SystemColors.Window;
            this.buttonBold.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonBold.Location = new System.Drawing.Point(543, 41);
            this.buttonBold.Name = "buttonBold";
            this.buttonBold.Size = new System.Drawing.Size(79, 23);
            this.buttonBold.TabIndex = 10;
            this.buttonBold.Text = "Bold";
            this.buttonBold.UseVisualStyleBackColor = false;
            this.buttonBold.Click += new System.EventHandler(this.buttonBold_Click);
            // 
            // italicButton
            // 
            this.italicButton.BackColor = System.Drawing.SystemColors.Window;
            this.italicButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.italicButton.Location = new System.Drawing.Point(458, 41);
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(79, 23);
            this.italicButton.TabIndex = 11;
            this.italicButton.Text = "Italic";
            this.italicButton.UseVisualStyleBackColor = false;
            this.italicButton.Click += new System.EventHandler(this.italicButton_Click);
            // 
            // underlineButton
            // 
            this.underlineButton.BackColor = System.Drawing.SystemColors.Window;
            this.underlineButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.underlineButton.Location = new System.Drawing.Point(373, 41);
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(79, 23);
            this.underlineButton.TabIndex = 12;
            this.underlineButton.Text = "Underline";
            this.underlineButton.UseVisualStyleBackColor = false;
            this.underlineButton.Click += new System.EventHandler(this.underlineButton_Click);
            // 
            // Noted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(895, 402);
            this.Controls.Add(this.underlineButton);
            this.Controls.Add(this.italicButton);
            this.Controls.Add(this.buttonBold);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.deleteButton);
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
        public Button deleteButton;
        public Button renameButton;
        public Button button1;
        private Button buttonBold;
        private Button italicButton;
        private Button underlineButton;
    }
}