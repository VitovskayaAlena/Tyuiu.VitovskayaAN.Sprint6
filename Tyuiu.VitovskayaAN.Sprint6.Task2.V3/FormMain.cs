using System.Windows.Forms.VisualStyles;
using Tyuiu.VitovskayaAN.Sprint6.Task2.V3.Lib;

namespace Tyuiu.VitovskayaAN.Sprint6.Task2.V3
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
                double[] array = new double[len];
                array = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_VAN.Titles.Add("График функции F(x)");
                this.chartFunction_VAN.ChartAreas[0].AxisX.Title = "Ось x";
                this.chartFunction_VAN.ChartAreas[0].AxisY.Title = "Ось y";
                for (int i = 0; i < len - 1; i++)
                {
                    this.dataGridViewFunction_VAN.Rows.Add(Convert.ToString(startStep), Convert.ToString(array[i]));
                    this.chartFunction_VAN.Series[0].Points.AddXY(startStep, array[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonDone_VAN_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_VAN.BackColor = Color.Red;
        }
        private void buttonDone_VAN_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_VAN.BackColor = Color.Green;
        }
        private void buttonDone_VAN_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_VAN.BackColor = Color.Blue;
        }
        private void buttonHelp_VAN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы РППб-25-1 Витовская Алёна Николаевна");
        }
    }
}
