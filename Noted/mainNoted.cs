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

        // Saving note
        private void saveButton_Click(object sender, EventArgs e) => saveNotes();

        // Delete note
        private void deleteButton_Click(object sender, EventArgs e) => deleteNote();

        public void saveNotes()
        {
            // Check if the file name or note content text boxes are empty
            if (string.IsNullOrEmpty(textFileName.Text) || string.IsNullOrEmpty(noteBox.Text))
            {
                MessageBox.Show("Cannot save a blank note");
                return;
            }

            // Define the folder and file path to save the note
            string folderName = "Noted";
            string fileName = textFileName.Text;
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), folderName);
            string filePath = Path.Combine(folderPath, fileName + ".txt");
            string textToSave = noteBox.Text;

            try
            {
                // Save the note to the file path
                File.WriteAllText(filePath, textToSave);
                // Add the file name and content to the dictionary
                dictionaryNotes[fileName] = textToSave;
                // Add the file name to the list box
                listBoxNotes.Items.Add(fileName);
                // Show a success message
                MessageBox.Show("Note succesfully saved!");
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
                    MessageBox.Show("Note deleted successfully.");
                }
                catch (Exception ex)
                {
                    // Show an error message if there was an exception
                    MessageBox.Show("Error deleting note: " + ex.Message);
                }
            }
        }

        private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Show note content when selected
            if (listBoxNotes.SelectedItem != null)
            {
                string selectedNote = listBoxNotes.SelectedItem.ToString();
                noteBox.Text = dictionaryNotes[selectedNote];
            }
        }
    }
}