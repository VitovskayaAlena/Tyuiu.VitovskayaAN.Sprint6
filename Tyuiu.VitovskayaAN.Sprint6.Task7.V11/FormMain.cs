using System;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using Tyuiu.VitovskayaAN.Sprint6.Task7.V11.Lib;
namespace Tyuiu.VitovskayaAN.Sprint6.Task7.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        static string openFilePath;
        static int rows;
        static int columns;
        DataService ds = new DataService();
        private void buttonHelp_VAN_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        public static int[,] LoadFromFileData(string FilePath)
        {
            string fileData = File.ReadAllText(FilePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line = lines[i].Split(";");
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = Convert.ToInt32(line[j]);
                }
            }
            return matrix;
        }
        private void buttonOpenFile_VAN_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            int[,] matrix = new int[rows, columns];

            matrix = LoadFromFileData(openFilePath);

            dataGridViewVvod_VAN.ColumnCount = columns;
            dataGridViewVvod_VAN.RowCount = rows;
            dataGridViewVivod_VAN.ColumnCount = columns;
            dataGridViewVivod_VAN.RowCount = rows;

            for (int h = 0; h < columns; h++)
            {
                dataGridViewVvod_VAN.Columns[h].Width = 70;
                dataGridViewVivod_VAN.Columns[h].Width = 70;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewVvod_VAN.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
            buttonDone_VAN.Enabled = true;
        }
        private void buttonDone_VAN_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[rows, columns];
            matrix = ds.GetMatrix(openFilePath);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewVivod_VAN.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
            buttonSave_VAN.Enabled = true;
        }

        private void buttonSave_VAN_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewVivod_VAN.RowCount;
            int columns = dataGridViewVivod_VAN.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewVivod_VAN.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewVivod_VAN.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }
    }

}