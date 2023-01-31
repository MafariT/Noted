namespace Noted
{
    public partial class Noted : Form
    {
        private Dictionary<string, string> dictionaryNotes = new Dictionary<string, string>();

        public Noted()
        {
            InitializeComponent();
            loadNotes();

            listBoxNotes.SelectedIndexChanged += new EventHandler(listBoxNotes_SelectedIndexChanged);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveNotes();
        }

        public void saveNotes()
        {
            if (string.IsNullOrEmpty(textFileName.Text) || string.IsNullOrEmpty(noteBox.Text))
            {
                MessageBox.Show("Cannot save a blank note");
                return;
            }

            string folderName = "Noted";
            string fileName = textFileName.Text;
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), folderName);
            string filePath = Path.Combine(folderPath, fileName + ".txt");
            string textToSave = noteBox.Text;

            try
            {
                File.WriteAllText(filePath, textToSave);
                dictionaryNotes[fileName] = textToSave;
                listBoxNotes.Items.Add(fileName);
                MessageBox.Show("Note succesfully saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving note: " + ex.Message);
            }
        }

        public void loadNotes()
        {
            string folderName = "Noted";
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), folderName);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            try
            {
                string[] files = Directory.GetFiles(folderPath, "*.txt");

                if (files.Length == 0)
                {
                    MessageBox.Show("No notes found.");
                    return;
                }
                foreach (string filePath in files)
                {
                    string fileName = Path.GetFileNameWithoutExtension(filePath);
                    string textLoaded = File.ReadAllText(filePath);
                    listBoxNotes.Items.Add(fileName);
                    dictionaryNotes.Add(fileName, textLoaded);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading notes: " + ex.Message);
            }
        }

        private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxNotes.SelectedItem != null)
            {
                string selectedNote = listBoxNotes.SelectedItem.ToString();
                noteBox.Text = dictionaryNotes[selectedNote];
            }
        }
    }
}