using Tyuiu.VitovskayaAN.Sprint6.Task3.V18.Lib;
namespace Tyuiu.VitovskayaAN.Sprint6.Task3.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = { { -19, -19, 1, 18, 7 }, 
                        { 5, 3, -4, -6, -12  }, 
                        { -15, 6, 2, 2, -14 }, 
                        { -9, -10, 15, -5, -6 }, 
                        { -13, -15, -9, 7, 1 } };
        private void buttonHelp_VAN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы РППб-25-1 Витовская Алёна Николаевна");
        }
        private void buttonDone_VAN_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtrx);
            int row = res.GetUpperBound(0) + 1;
            int col = res.Length / row;
            dataGridViewMatrix_VAN.ColumnCount = col;
            dataGridViewMatrix_VAN.RowCount = row;
            for (int i = 0; i < col; i++)
            {
                dataGridViewMatrix_VAN.Columns[i].Width = 100;
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    dataGridViewMatrix_VAN.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int cols = mtrx.Length / rows;
            dataGridViewMatrix_VAN.ColumnCount = cols;
            dataGridViewMatrix_VAN.RowCount = rows;
            for (int i = 0; i < cols; i++)
            {
                dataGridViewMatrix_VAN.Columns[i].Width = 100;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewMatrix_VAN.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
    }
}