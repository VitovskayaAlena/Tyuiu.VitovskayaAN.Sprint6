using Tyuiu.VitovskayaAN.Sprint6.Task6.V9.Lib;
namespace Tyuiu.VitovskayaAN.Sprint6.Task6.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonDone_VAN_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxVivod_VAN.Text = ds.CollectTextFromFile(openFilePath);

        }
        private void buttonOpen_VAN_Click(object sender, EventArgs e)
        {
            openFileDialog_VAN.ShowDialog();
            openFilePath = openFileDialog_VAN.FileName;
            try
            {
                textBoxVvod_VAN.Text = File.ReadAllText(openFilePath);
                panelVvod_VAN.Text = panelVvod_VAN.Text + " " + openFileDialog_VAN.FileName;
                buttonDone_VAN.Enabled = true;
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void buttonHelp_VAN_Click(object sender, EventArgs e)
        {

            FormAbout formAbout_AAR = new FormAbout();
            formAbout_AAR.ShowDialog();
        }
    }
}