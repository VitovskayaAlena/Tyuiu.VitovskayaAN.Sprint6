namespace Tyuiu.VitovskayaAN.Sprint6.Task5.V14
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartFunction_VAN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonOpen_VAN = new Button();
            buttonDone_VAN = new Button();
            buttonHelp_VAN = new Button();
            textBoxTask_VAN = new TextBox();
            groupBoxTask_VAN = new GroupBox();
            panelResult_VAN = new Panel();
            dataGridViewResult_VAN = new DataGridView();
            labelResult_VAN = new Label();
            ((System.ComponentModel.ISupportInitialize)chartFunction_VAN).BeginInit();
            groupBoxTask_VAN.SuspendLayout();
            panelResult_VAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_VAN).BeginInit();
            SuspendLayout();
            // 
            // chartFunction_VAN
            // 
            chartFunction_VAN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea2.Name = "ChartArea1";
            chartFunction_VAN.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartFunction_VAN.Legends.Add(legend2);
            chartFunction_VAN.Location = new Point(532, 165);
            chartFunction_VAN.Name = "chartFunction_VAN";
            chartFunction_VAN.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunction_VAN.Series.Add(series2);
            chartFunction_VAN.Size = new Size(1207, 829);
            chartFunction_VAN.TabIndex = 0;
            chartFunction_VAN.Text = "chart1";
            // 
            // buttonOpen_VAN
            // 
            buttonOpen_VAN.Anchor = AnchorStyles.Top;
            buttonOpen_VAN.BackColor = Color.Turquoise;
            buttonOpen_VAN.Location = new Point(1305, 56);
            buttonOpen_VAN.Name = "buttonOpen_VAN";
            buttonOpen_VAN.Size = new Size(185, 73);
            buttonOpen_VAN.TabIndex = 1;
            buttonOpen_VAN.Text = "Открыть файл";
            buttonOpen_VAN.UseVisualStyleBackColor = false;
            buttonOpen_VAN.Click += buttonOpen_VAN_Click;
            // 
            // buttonDone_VAN
            // 
            buttonDone_VAN.Anchor = AnchorStyles.Top;
            buttonDone_VAN.BackColor = Color.YellowGreen;
            buttonDone_VAN.Location = new Point(1062, 56);
            buttonDone_VAN.Name = "buttonDone_VAN";
            buttonDone_VAN.Size = new Size(193, 73);
            buttonDone_VAN.TabIndex = 2;
            buttonDone_VAN.Text = "Выполнить";
            buttonDone_VAN.UseVisualStyleBackColor = false;
            buttonDone_VAN.Click += buttonDone_AVV_Click;
            // 
            // buttonHelp_VAN
            // 
            buttonHelp_VAN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_VAN.BackColor = Color.RoyalBlue;
            buttonHelp_VAN.Location = new Point(1526, 56);
            buttonHelp_VAN.Name = "buttonHelp_VAN";
            buttonHelp_VAN.Size = new Size(169, 73);
            buttonHelp_VAN.TabIndex = 3;
            buttonHelp_VAN.Text = "Справка";
            buttonHelp_VAN.UseVisualStyleBackColor = false;
            buttonHelp_VAN.Click += buttonHelp_VAN_Click;
            // 
            // textBoxTask_VAN
            // 
            textBoxTask_VAN.Location = new Point(6, 38);
            textBoxTask_VAN.Multiline = true;
            textBoxTask_VAN.Name = "textBoxTask_VAN";
            textBoxTask_VAN.ReadOnly = true;
            textBoxTask_VAN.Size = new Size(986, 79);
            textBoxTask_VAN.TabIndex = 4;
            textBoxTask_VAN.Text = "Прочитать данные из файла InPutFileTask5V14.txt. Вывести в dataGridView. \r\nВывести все числа, больше или равные 10. Построить диаграмму по этим значениям.";
            // 
            // groupBoxTask_VAN
            // 
            groupBoxTask_VAN.Controls.Add(textBoxTask_VAN);
            groupBoxTask_VAN.Location = new Point(12, 12);
            groupBoxTask_VAN.Name = "groupBoxTask_VAN";
            groupBoxTask_VAN.Size = new Size(1015, 134);
            groupBoxTask_VAN.TabIndex = 5;
            groupBoxTask_VAN.TabStop = false;
            groupBoxTask_VAN.Text = "Условие";
            // 
            // panelResult_VAN
            // 
            panelResult_VAN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelResult_VAN.Controls.Add(dataGridViewResult_VAN);
            panelResult_VAN.Location = new Point(1, 165);
            panelResult_VAN.Name = "panelResult_VAN";
            panelResult_VAN.RightToLeft = RightToLeft.Yes;
            panelResult_VAN.Size = new Size(412, 841);
            panelResult_VAN.TabIndex = 6;
            // 
            // dataGridViewResult_VAN
            // 
            dataGridViewResult_VAN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewResult_VAN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_VAN.ColumnHeadersVisible = false;
            dataGridViewResult_VAN.Location = new Point(0, 19);
            dataGridViewResult_VAN.Name = "dataGridViewResult_VAN";
            dataGridViewResult_VAN.ReadOnly = true;
            dataGridViewResult_VAN.RightToLeft = RightToLeft.No;
            dataGridViewResult_VAN.RowHeadersVisible = false;
            dataGridViewResult_VAN.RowHeadersWidth = 82;
            dataGridViewResult_VAN.ScrollBars = ScrollBars.Horizontal;
            dataGridViewResult_VAN.Size = new Size(409, 822);
            dataGridViewResult_VAN.TabIndex = 0;
            // 
            // labelResult_VAN
            // 
            labelResult_VAN.AutoSize = true;
            labelResult_VAN.Location = new Point(12, 132);
            labelResult_VAN.Name = "labelResult_VAN";
            labelResult_VAN.Size = new Size(90, 32);
            labelResult_VAN.TabIndex = 5;
            labelResult_VAN.Text = "Вывод:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1744, 1006);
            Controls.Add(labelResult_VAN);
            Controls.Add(panelResult_VAN);
            Controls.Add(groupBoxTask_VAN);
            Controls.Add(buttonHelp_VAN);
            Controls.Add(buttonDone_VAN);
            Controls.Add(buttonOpen_VAN);
            Controls.Add(chartFunction_VAN);
            MinimumSize = new Size(1770, 1077);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Tаск 5 | Вариант 14 | Витовская А. Н.";
            ((System.ComponentModel.ISupportInitialize)chartFunction_VAN).EndInit();
            groupBoxTask_VAN.ResumeLayout(false);
            groupBoxTask_VAN.PerformLayout();
            panelResult_VAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_VAN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_VAN;
        private Button buttonOpen_VAN;
        private Button buttonDone_VAN;
        private Button buttonHelp_VAN;
        private TextBox textBoxTask_VAN;
        private GroupBox groupBoxTask_VAN;
        private Panel panelResult_VAN;
        private Label labelResult_VAN;
        private DataGridView dataGridViewResult_VAN;
    }
}
