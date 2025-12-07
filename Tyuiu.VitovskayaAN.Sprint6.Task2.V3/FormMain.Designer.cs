namespace Tyuiu.VitovskayaAN.Sprint6.Task2.V3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            textBoxTask_VAN = new TextBox();
            groupBoxTask_VAN = new GroupBox();
            textBoxStop_VAN = new TextBox();
            textBoxStart_VAN = new TextBox();
            labelStop_VAN = new Label();
            labelStart_VAN = new Label();
            buttonHelp_VAN = new Button();
            buttonDone_VAN = new Button();
            groupBoxResult_VAN = new GroupBox();
            dataGridViewFunction_VAN = new DataGridView();
            x = new DataGridViewTextBoxColumn();
            y = new DataGridViewTextBoxColumn();
            chartFunction_VAN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            labelResult_VAN = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxTask_VAN.SuspendLayout();
            groupBoxResult_VAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_VAN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_VAN).BeginInit();
            SuspendLayout();
            // 
            // textBoxTask_VAN
            // 
            textBoxTask_VAN.Location = new Point(21, 12);
            textBoxTask_VAN.Multiline = true;
            textBoxTask_VAN.Name = "textBoxTask_VAN";
            textBoxTask_VAN.ReadOnly = true;
            textBoxTask_VAN.Size = new Size(989, 615);
            textBoxTask_VAN.TabIndex = 0;
            textBoxTask_VAN.Text = "Условие\r\n\r\nПротабулировать функцию на заданном диапазоне.\r\nРезультат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxTask_VAN
            // 
            groupBoxTask_VAN.Controls.Add(textBoxStop_VAN);
            groupBoxTask_VAN.Controls.Add(textBoxStart_VAN);
            groupBoxTask_VAN.Controls.Add(labelStop_VAN);
            groupBoxTask_VAN.Controls.Add(labelStart_VAN);
            groupBoxTask_VAN.Location = new Point(12, 632);
            groupBoxTask_VAN.Name = "groupBoxTask_VAN";
            groupBoxTask_VAN.Size = new Size(581, 161);
            groupBoxTask_VAN.TabIndex = 1;
            groupBoxTask_VAN.TabStop = false;
            groupBoxTask_VAN.Text = "Ввод данных";
            // 
            // textBoxStop_VAN
            // 
            textBoxStop_VAN.Location = new Point(340, 104);
            textBoxStop_VAN.Name = "textBoxStop_VAN";
            textBoxStop_VAN.Size = new Size(198, 39);
            textBoxStop_VAN.TabIndex = 2;
            // 
            // textBoxStart_VAN
            // 
            textBoxStart_VAN.Location = new Point(9, 104);
            textBoxStart_VAN.Name = "textBoxStart_VAN";
            textBoxStart_VAN.Size = new Size(198, 39);
            textBoxStart_VAN.TabIndex = 2;
            // 
            // labelStop_VAN
            // 
            labelStop_VAN.AutoSize = true;
            labelStop_VAN.Location = new Point(353, 52);
            labelStop_VAN.Name = "labelStop_VAN";
            labelStop_VAN.Size = new Size(147, 32);
            labelStop_VAN.TabIndex = 1;
            labelStop_VAN.Text = "Конец шага:";
            // 
            // labelStart_VAN
            // 
            labelStart_VAN.AutoSize = true;
            labelStart_VAN.Location = new Point(9, 52);
            labelStart_VAN.Name = "labelStart_VAN";
            labelStart_VAN.Size = new Size(139, 32);
            labelStart_VAN.TabIndex = 0;
            labelStart_VAN.Text = "Старт шага:";
            // 
            // buttonHelp_VAN
            // 
            buttonHelp_VAN.BackColor = SystemColors.MenuHighlight;
            buttonHelp_VAN.Location = new Point(599, 663);
            buttonHelp_VAN.Name = "buttonHelp_VAN";
            buttonHelp_VAN.Size = new Size(163, 112);
            buttonHelp_VAN.TabIndex = 2;
            buttonHelp_VAN.Text = "Справка";
            buttonHelp_VAN.UseVisualStyleBackColor = false;
            buttonHelp_VAN.Click += buttonHelp_VAN_Click;
            // 
            // buttonDone_VAN
            // 
            buttonDone_VAN.BackColor = Color.Green;
            buttonDone_VAN.ForeColor = SystemColors.ActiveCaptionText;
            buttonDone_VAN.Location = new Point(777, 663);
            buttonDone_VAN.Name = "buttonDone_VAN";
            buttonDone_VAN.Size = new Size(233, 112);
            buttonDone_VAN.TabIndex = 3;
            buttonDone_VAN.Text = "Выполнить";
            buttonDone_VAN.UseVisualStyleBackColor = false;
            buttonDone_VAN.Click += buttonDone_VAN_Click;
            buttonDone_VAN.MouseDown += buttonDone_VAN_MouseDown;
            buttonDone_VAN.MouseEnter += buttonDone_VAN_MouseEnter;
            buttonDone_VAN.MouseLeave += buttonDone_VAN_MouseLeave;
            // 
            // groupBoxResult_VAN
            // 
            groupBoxResult_VAN.Controls.Add(dataGridViewFunction_VAN);
            groupBoxResult_VAN.Controls.Add(chartFunction_VAN);
            groupBoxResult_VAN.Controls.Add(labelResult_VAN);
            groupBoxResult_VAN.Location = new Point(1016, 12);
            groupBoxResult_VAN.Name = "groupBoxResult_VAN";
            groupBoxResult_VAN.Size = new Size(1142, 781);
            groupBoxResult_VAN.TabIndex = 4;
            groupBoxResult_VAN.TabStop = false;
            groupBoxResult_VAN.Text = "Вывод данных";
            // 
            // dataGridViewFunction_VAN
            // 
            dataGridViewFunction_VAN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_VAN.Columns.AddRange(new DataGridViewColumn[] { x, y });
            dataGridViewFunction_VAN.Location = new Point(0, 88);
            dataGridViewFunction_VAN.Name = "dataGridViewFunction_VAN";
            dataGridViewFunction_VAN.RowHeadersVisible = false;
            dataGridViewFunction_VAN.RowHeadersWidth = 82;
            dataGridViewFunction_VAN.Size = new Size(359, 626);
            dataGridViewFunction_VAN.TabIndex = 2;
            // 
            // x
            // 
            x.HeaderText = "x";
            x.MinimumWidth = 10;
            x.Name = "x";
            x.Width = 200;
            // 
            // y
            // 
            y.HeaderText = "y";
            y.MinimumWidth = 10;
            y.Name = "y";
            y.Width = 200;
            // 
            // chartFunction_VAN
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_VAN.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_VAN.Legends.Add(legend1);
            chartFunction_VAN.Location = new Point(355, 88);
            chartFunction_VAN.Name = "chartFunction_VAN";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_VAN.Series.Add(series1);
            chartFunction_VAN.Size = new Size(944, 626);
            chartFunction_VAN.TabIndex = 1;
            chartFunction_VAN.Text = "chart1";
            // 
            // labelResult_VAN
            // 
            labelResult_VAN.AutoSize = true;
            labelResult_VAN.Location = new Point(6, 47);
            labelResult_VAN.Name = "labelResult_VAN";
            labelResult_VAN.Size = new Size(125, 32);
            labelResult_VAN.TabIndex = 0;
            labelResult_VAN.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2096, 803);
            Controls.Add(groupBoxResult_VAN);
            Controls.Add(buttonDone_VAN);
            Controls.Add(buttonHelp_VAN);
            Controls.Add(groupBoxTask_VAN);
            Controls.Add(textBoxTask_VAN);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Tаск 2 | Вариант 3 | Витовская А. Н.";
            groupBoxTask_VAN.ResumeLayout(false);
            groupBoxTask_VAN.PerformLayout();
            groupBoxResult_VAN.ResumeLayout(false);
            groupBoxResult_VAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_VAN).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_VAN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTask_VAN;
        private GroupBox groupBoxTask_VAN;
        private TextBox textBoxStart_VAN;
        private Label labelStop_VAN;
        private Label labelStart_VAN;
        private TextBox textBoxStop_VAN;
        private Button buttonHelp_VAN;
        private Button buttonDone_VAN;
        private GroupBox groupBoxResult_VAN;
        private Label labelResult_VAN;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_VAN;
        private DataGridView dataGridViewFunction_VAN;
        private DataGridViewTextBoxColumn x;
        private DataGridViewTextBoxColumn y;
    }
}
