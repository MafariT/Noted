namespace Noted
{
    public partial class Noted : Form
    {
        public Noted()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string filePath = "notes.txt";
            string textToSave = noteBox.Text;

            try
            {
                File.WriteAllText(filePath, textToSave);
                MessageBox.Show("Note succesfully saved!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error saving note: " + ex.Message);
            }

                
        }
    }
}