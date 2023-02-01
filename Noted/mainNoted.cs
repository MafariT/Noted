namespace Noted
{
    public partial class Noted : Form
    {
        // A dictionary to store the file names and contents of saved notes
        private Dictionary<string, string> dictionaryNotes = new Dictionary<string, string>();

        public Noted()
        {
            InitializeComponent();
            loadNotes();
            // Event handler for when a note is selected from the list box
            listBoxNotes.SelectedIndexChanged += new EventHandler(listBoxNotes_SelectedIndexChanged);
        }
        // Buttons
        private void createButton_Click(object sender, EventArgs e) => createNotes();

        private void deleteButton_Click(object sender, EventArgs e) => deleteNote();

        private void renameButton_Click(object sender, EventArgs e) => renameNote();

        private void newButton_Click(object sender, EventArgs e) => newNote();

        private void saveButton_Click(object sender, EventArgs e) => saveNote();

        private void buttonBold_Click(object sender, EventArgs e) => boldText();

        private void italicButton_Click(object sender, EventArgs e) => italicText();

        private void underlineButton_Click(object sender, EventArgs e) => underlineText();

        private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e) => showTextSelectedNote();

        public void createNotes()
        {
            // Check if the file name or note content text boxes are empty
            if (string.IsNullOrEmpty(textFileName.Text) || string.IsNullOrEmpty(noteBox.Text))
            {
                MessageBox.Show("Cannot create a blank note");
                return;
            }
            // Define the folder and file path to save the note
            string folderName = "Noted";
            string fileName = textFileName.Text;
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), folderName);
            string filePath = Path.Combine(folderPath, fileName + ".txt");
            string textToSave = noteBox.Rtf;
            // Check if there is same file with that name
            if (listBoxNotes.Items.Contains(fileName))
            {
                MessageBox.Show("File already exists with that name.");
                return;
            }
            try
            {
                // Save the note to the file path
                File.WriteAllText(filePath, textToSave);
                // Add the file name and content to the dictionary
                dictionaryNotes[fileName] = textToSave;
                // Add the file name to the list box
                listBoxNotes.Items.Add(fileName);
                // Clearing file name
                textFileName.Text = "";
                // Show a success message
                MessageBox.Show("Note succesfully created!");
            }
            catch (Exception ex)
            {
                // Show an error message if there was an exception
                MessageBox.Show("Error saving note: " + ex.Message);
            }
        }

        public void loadNotes()
        {
            // Define the folder path to load the notes from
            string folderName = "Noted";
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), folderName);

            // Check if the folder exists and create it if it doesn't
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            try
            {
                // Get the text files from the folder
                string[] files = Directory.GetFiles(folderPath, "*.txt");

                if (files.Length == 0)
                {
                    // Show a message if no notes were found
                    MessageBox.Show("No notes found.");
                    return;
                }
                foreach (string filePath in files)
                {
                    // Get the file name without the extension
                    string fileName = Path.GetFileNameWithoutExtension(filePath);
                    // Load the contents of the file
                    string textLoaded = File.ReadAllText(filePath);
                    // Add the file name to the list box
                    listBoxNotes.Items.Add(fileName);
                    // Add the file name and content to the dictionary
                    dictionaryNotes.Add(fileName, textLoaded);
                }
            }
            catch (Exception ex)
            {
                // Show an error message if there was an exception
                MessageBox.Show("Error loading notes: " + ex.Message);
            }
        }

        public void deleteNote()
        {
            // Checking if no note selected
            string selectedFile = listBoxNotes.SelectedItem as string;
            if (selectedFile == null)
            {
                // If so this message will show
                MessageBox.Show("No note selected to delete");
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this note?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Define the folder path to delete note
                string folderName = "Noted";
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), folderName);
                string filePath = Path.Combine(folderPath, selectedFile + ".txt");
                try
                {
                    // Delete note
                    File.Delete(filePath);
                    // Deleting note from dictionary
                    dictionaryNotes.Remove(selectedFile);
                    // Deleting note from listbox
                    listBoxNotes.Items.Remove(selectedFile);
                    // Clearing file name
                    textFileName.Text = "";
                    // Clearing text
                    noteBox.Text = "";
                }
                catch (Exception ex)
                {
                    // Show an error message if there was an exception
                    MessageBox.Show("Error deleting note: " + ex.Message);
                }
            }
        }

        public void renameNote()
        {
            if (listBoxNotes.SelectedItem == null)
            {
                MessageBox.Show("Please select a note to rename.");
                return;
            }
            string selectedFile = listBoxNotes.SelectedItem.ToString();
            string newFileName = Microsoft.VisualBasic.Interaction.InputBox("Enter a new name for the file:", "Rename File", selectedFile);

            if (string.IsNullOrEmpty(newFileName))
            {
                MessageBox.Show("Invalid file name.");
                return;
            }
            if (listBoxNotes.Items.Contains(newFileName))
            {
                MessageBox.Show("File already exists with that name.");
                return;
            }
            //  Define the folder path to rename note
            string folderName = "Noted";
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), folderName);
            string oldFilePath = Path.Combine(folderPath, selectedFile + ".txt");
            string newFilePath = Path.Combine(folderPath, newFileName + ".txt");
            try
            {
                // Replacing old note with the new note
                File.Move(oldFilePath, newFilePath);
                string text = dictionaryNotes[selectedFile];
                dictionaryNotes.Remove(selectedFile);
                dictionaryNotes.Add(newFileName, text);
                listBoxNotes.Items.Remove(selectedFile);
                listBoxNotes.Items.Add(newFileName);
                // Clearing file name
                textFileName.Text = "";
                MessageBox.Show("File renamed successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error renaming file: " + ex.Message);
            }
        }

        public void saveNote()
        {
            if (listBoxNotes.SelectedItem == null)
            {
                MessageBox.Show("Please select a note to edit.");
                return;
            }
            string folderName = "Noted";
            string fileName = listBoxNotes.SelectedItem.ToString();
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), folderName);
            string filePath = Path.Combine(folderPath, fileName + ".txt");
            string textToSave = noteBox.Rtf;
            try
            {
                // Edit note
                File.WriteAllText(filePath, textToSave);
                // Clearing the note list so that it wont thrown an error
                listBoxNotes.Items.Clear();
                dictionaryNotes.Clear();
                // Loading back the updated note list
                loadNotes();
                MessageBox.Show("Note succesfully saved!");
            }
            catch (Exception ex)
            {
                // Show an error message if there was an exception
                MessageBox.Show("Error saving note: " + ex.Message);
            }
        }

        public void showTextSelectedNote()
        {
            // Show note content when selected
            if (listBoxNotes.SelectedItem != null)
            {
                string selectedNote = listBoxNotes.SelectedItem.ToString();
                noteBox.Rtf = dictionaryNotes[selectedNote];
            }
        }

        public void boldText()
        {
            if (noteBox.SelectionFont == null) return;
            Font oldFont = noteBox.SelectionFont;
            Font newFont = new Font(oldFont, oldFont.Style ^ FontStyle.Bold);
            noteBox.SelectionFont = newFont;
        }

        public void italicText()
        {
            if (noteBox.SelectionFont == null) return;
            Font oldFont = noteBox.SelectionFont;
            Font newFont = new Font(oldFont, oldFont.Style ^ FontStyle.Italic);
            noteBox.SelectionFont = newFont;
        }

        public void underlineText()
        {
            if (noteBox.SelectionFont == null) return;
            Font oldFont = noteBox.SelectionFont;
            Font newFont = new Font(oldFont, oldFont.Style ^ FontStyle.Underline);
            noteBox.SelectionFont = newFont;
        }

        // Clearing file name and text note
        public void newNote()
        {
            noteBox.Text = "";
            textFileName.Text = "";
        }
    }
}