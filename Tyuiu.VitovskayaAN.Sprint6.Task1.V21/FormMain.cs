using System.Drawing.Text;
using Tyuiu.VitovskayaAN.Sprint6.Task1.V21.Lib;
namespace Tyuiu.VitovskayaAN.Sprint6.Task1.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_VAN_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_VAN.Text);
                int stopStep = Convert.ToInt32(textBoxStop_VAN.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult.Text = "";
                textBoxResult.AppendText("+-----------+------------+" + Environment.NewLine);
                textBoxResult.AppendText("|     X     |    f(x)    |" + Environment.NewLine);
                textBoxResult.AppendText("+-----------+------------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|  {0,5:d}    |   {1, 6:f2}   |", startStep, valueArray[i]);
                    textBoxResult.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult.AppendText("+-----------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_VAN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы РППб-25-1 Витовская Алёна Николаевна");
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStop_VAN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}