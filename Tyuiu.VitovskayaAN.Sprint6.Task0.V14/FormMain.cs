using System.Windows.Forms;
using Tyuiu.VitovskayaAN.Sprint6.Task0.V14.Lib;
namespace Tyuiu.VitovskayaAN.Sprint6.Task0.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxRes_VAN.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxRes_VAN.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxRes(object sender, EventArgs e)
        {

        }

        private void textBoxPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47) || (e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }

        }

        private void Условие(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы РППб-25-1 Витовская Алёна Николаевна");
        }
    }
}
