using System;
using Tyuiu.VitovskayaAN.Sprint6.Task5.V14.Lib;
namespace Tyuiu.VitovskayaAN.Sprint6.Task5.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\DataSprint6\InPutDataFileTask5V14.txt";

        private void buttonDone_AVV_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewResult_VAN.ColumnCount = 2;
                dataGridViewResult_VAN.Columns[0].Width = 100;
                dataGridViewResult_VAN.Columns[1].Width = 100;

                this.chartFunction_VAN.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_VAN.ChartAreas[0].AxisY.Title = "Ось Y";

                chartFunction_VAN.Series[0].Points.Clear();

                double[] numsMass = new double[ds.len];

                numsMass = ds.LoadFromDataFile(path);

                for (int i = 0; i < numsMass.Length; i++)
                {
                    dataGridViewResult_VAN.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                    chartFunction_VAN.Series[0].Points.AddXY(i, numsMass[i]);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка работы файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonOpen_VAN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_VAN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы РППб-25-1 Витовская Алёна Николаевна");
        }
    }
}
