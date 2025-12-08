namespace Tyuiu.VitovskayaAN.Sprint6.Task4.V21
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
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxTask_VAN = new GroupBox();
            textBoxTask_VAN = new TextBox();
            groupBoxInput_VAN = new GroupBox();
            textBoxStop_VAN = new TextBox();
            textBoxStart_VAN = new TextBox();
            labelStop_VAN = new Label();
            labelStart_VAN = new Label();
            buttonDone_VAN = new Button();
            buttonHelp_VAN = new Button();
            buttonSave_VAN = new Button();
            textBoxResult_VAN = new TextBox();
            chartResult_VAN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            labelResult_VAN = new Label();
            panelResult_VAN = new Panel();
            splitter1 = new Splitter();
            groupBoxTask_VAN.SuspendLayout();
            groupBoxInput_VAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult_VAN).BeginInit();
            panelResult_VAN.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_VAN
            // 
            groupBoxTask_VAN.Controls.Add(textBoxTask_VAN);
            groupBoxTask_VAN.Location = new Point(571, 1);
            groupBoxTask_VAN.Name = "groupBoxTask_VAN";
            groupBoxTask_VAN.Size = new Size(546, 468);
            groupBoxTask_VAN.TabIndex = 0;
            groupBoxTask_VAN.TabStop = false;
            groupBoxTask_VAN.Text = "Условие";
            // 
            // textBoxTask_VAN
            // 
            textBoxTask_VAN.Location = new Point(10, 38);
            textBoxTask_VAN.Multiline = true;
            textBoxTask_VAN.Name = "textBoxTask_VAN";
            textBoxTask_VAN.ReadOnly = true;
            textBoxTask_VAN.Size = new Size(512, 421);
            textBoxTask_VAN.TabIndex = 0;
            textBoxTask_VAN.Text = "Протабулировать функцию f(x) на заданном диапазоне\r\nРезультат вывести в DataGridView и построить график функции";
            // 
            // groupBoxInput_VAN
            // 
            groupBoxInput_VAN.Controls.Add(textBoxStop_VAN);
            groupBoxInput_VAN.Controls.Add(textBoxStart_VAN);
            groupBoxInput_VAN.Controls.Add(labelStop_VAN);
            groupBoxInput_VAN.Controls.Add(labelStart_VAN);
            groupBoxInput_VAN.Location = new Point(616, 493);
            groupBoxInput_VAN.Name = "groupBoxInput_VAN";
            groupBoxInput_VAN.Size = new Size(425, 140);
            groupBoxInput_VAN.TabIndex = 1;
            groupBoxInput_VAN.TabStop = false;
            groupBoxInput_VAN.Text = "Ввод данных";
            // 
            // textBoxStop_VAN
            // 
            textBoxStop_VAN.Location = new Point(220, 86);
            textBoxStop_VAN.Name = "textBoxStop_VAN";
            textBoxStop_VAN.Size = new Size(200, 39);
            textBoxStop_VAN.TabIndex = 3;
            // 
            // textBoxStart_VAN
            // 
            textBoxStart_VAN.Location = new Point(6, 86);
            textBoxStart_VAN.Name = "textBoxStart_VAN";
            textBoxStart_VAN.Size = new Size(181, 39);
            textBoxStart_VAN.TabIndex = 2;
            textBoxStart_VAN.KeyPress += textBoxStart_VAN_KeyPress;
            // 
            // labelStop_VAN
            // 
            labelStop_VAN.AutoSize = true;
            labelStop_VAN.Location = new Point(220, 51);
            labelStop_VAN.Name = "labelStop_VAN";
            labelStop_VAN.Size = new Size(147, 32);
            labelStop_VAN.TabIndex = 1;
            labelStop_VAN.Text = "Конец шага:";
            // 
            // labelStart_VAN
            // 
            labelStart_VAN.AutoSize = true;
            labelStart_VAN.Location = new Point(6, 51);
            labelStart_VAN.Name = "labelStart_VAN";
            labelStart_VAN.Size = new Size(139, 32);
            labelStart_VAN.TabIndex = 0;
            labelStart_VAN.Text = "Старт шага:";
            // 
            // buttonDone_VAN
            // 
            buttonDone_VAN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonDone_VAN.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone_VAN.Location = new Point(614, 784);
            buttonDone_VAN.Name = "buttonDone_VAN";
            buttonDone_VAN.Size = new Size(147, 106);
            buttonDone_VAN.TabIndex = 2;
            buttonDone_VAN.Text = "Выполнить";
            buttonDone_VAN.UseVisualStyleBackColor = false;
            buttonDone_VAN.Click += buttonDone_VAN_Click;
            // 
            // buttonHelp_VAN
            // 
            buttonHelp_VAN.Anchor = AnchorStyles.Bottom;
            buttonHelp_VAN.BackColor = SystemColors.ActiveCaption;
            buttonHelp_VAN.Location = new Point(958, 784);
            buttonHelp_VAN.Name = "buttonHelp_VAN";
            buttonHelp_VAN.Size = new Size(135, 106);
            buttonHelp_VAN.TabIndex = 3;
            buttonHelp_VAN.Text = "Справка";
            buttonHelp_VAN.UseVisualStyleBackColor = false;
            buttonHelp_VAN.Click += buttonHelp_VAN_Click;
            // 
            // buttonSave_VAN
            // 
            buttonSave_VAN.Anchor = AnchorStyles.Bottom;
            buttonSave_VAN.BackColor = Color.SteelBlue;
            buttonSave_VAN.Location = new Point(780, 784);
            buttonSave_VAN.Name = "buttonSave_VAN";
            buttonSave_VAN.Size = new Size(143, 106);
            buttonSave_VAN.TabIndex = 4;
            buttonSave_VAN.Text = "Сохранить";
            buttonSave_VAN.UseVisualStyleBackColor = false;
            buttonSave_VAN.Click += buttonSave_VAN_Click;
            // 
            // textBoxResult_VAN
            // 
            textBoxResult_VAN.Dock = DockStyle.Left;
            textBoxResult_VAN.Location = new Point(0, 0);
            textBoxResult_VAN.Multiline = true;
            textBoxResult_VAN.Name = "textBoxResult_VAN";
            textBoxResult_VAN.Size = new Size(493, 917);
            textBoxResult_VAN.TabIndex = 5;
            // 
            // chartResult_VAN
            // 
            chartResult_VAN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            chartArea2.Name = "ChartArea1";
            chartResult_VAN.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartResult_VAN.Legends.Add(legend2);
            chartResult_VAN.Location = new Point(1123, 1);
            chartResult_VAN.Name = "chartResult_VAN";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "SeriesFunction";
            chartResult_VAN.Series.Add(series2);
            chartResult_VAN.Size = new Size(892, 904);
            chartResult_VAN.TabIndex = 6;
            title2.Name = "TitleFunction";
            title2.Text = "График функции f(x)";
            chartResult_VAN.Titles.Add(title2);
            // 
            // labelResult_VAN
            // 
            labelResult_VAN.AutoSize = true;
            labelResult_VAN.Location = new Point(12, 4);
            labelResult_VAN.Name = "labelResult_VAN";
            labelResult_VAN.Size = new Size(85, 32);
            labelResult_VAN.TabIndex = 7;
            labelResult_VAN.Text = "Вывод";
            // 
            // panelResult_VAN
            // 
            panelResult_VAN.Controls.Add(splitter1);
            panelResult_VAN.Controls.Add(textBoxResult_VAN);
            panelResult_VAN.Dock = DockStyle.Left;
            panelResult_VAN.Location = new Point(0, 0);
            panelResult_VAN.Name = "panelResult_VAN";
            panelResult_VAN.Size = new Size(496, 917);
            panelResult_VAN.TabIndex = 8;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(493, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 917);
            splitter1.TabIndex = 6;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2027, 917);
            Controls.Add(panelResult_VAN);
            Controls.Add(labelResult_VAN);
            Controls.Add(chartResult_VAN);
            Controls.Add(buttonSave_VAN);
            Controls.Add(buttonHelp_VAN);
            Controls.Add(buttonDone_VAN);
            Controls.Add(groupBoxInput_VAN);
            Controls.Add(groupBoxTask_VAN);
            MinimumSize = new Size(2053, 988);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Спринт 6 | Tаск 4 | Вариант 21 | Витовская А. Н.";
            groupBoxTask_VAN.ResumeLayout(false);
            groupBoxTask_VAN.PerformLayout();
            groupBoxInput_VAN.ResumeLayout(false);
            groupBoxInput_VAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult_VAN).EndInit();
            panelResult_VAN.ResumeLayout(false);
            panelResult_VAN.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxTask_VAN;
        private GroupBox groupBoxInput_VAN;
        private TextBox textBoxStop_VAN;
        private TextBox textBoxStart_VAN;
        private Label labelStop_VAN;
        private Label labelStart_VAN;
        private Button buttonDone_VAN;
        private Button buttonHelp_VAN;
        private Button buttonSave_VAN;
        private TextBox textBoxResult_VAN;
        private TextBox textBoxTask_VAN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_VAN;
        private Label labelResult_VAN;
        private Panel panelResult_VAN;
        private Splitter splitter1;
    }
}
