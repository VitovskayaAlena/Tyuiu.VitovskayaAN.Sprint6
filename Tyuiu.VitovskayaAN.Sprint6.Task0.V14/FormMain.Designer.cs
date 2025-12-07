namespace Tyuiu.VitovskayaAN.Sprint6.Task0.V14
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
            buttonDone_VAN = new Button();
            buttonInfo_VAN = new Button();
            textBoxRes_VAN = new TextBox();
            textBoxPer_VAN = new TextBox();
            pictureBoxFormula_VAN = new PictureBox();
            groupBoxTask_VAN = new GroupBox();
            labelWhatNeed_VAN = new Label();
            labelPer_VAN = new Label();
            labelVvod_VAN = new Label();
            labelRes_VAN = new Label();
            labelVivod_VAN = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_VAN).BeginInit();
            groupBoxTask_VAN.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone_VAN
            // 
            buttonDone_VAN.Location = new Point(820, 579);
            buttonDone_VAN.Name = "buttonDone_VAN";
            buttonDone_VAN.Size = new Size(213, 48);
            buttonDone_VAN.TabIndex = 1;
            buttonDone_VAN.Text = "Выполнить";
            buttonDone_VAN.UseVisualStyleBackColor = true;
            buttonDone_VAN.Click += buttonDone_Click;
            // 
            // buttonInfo_VAN
            // 
            buttonInfo_VAN.Location = new Point(743, 579);
            buttonInfo_VAN.Name = "buttonInfo_VAN";
            buttonInfo_VAN.Size = new Size(47, 48);
            buttonInfo_VAN.TabIndex = 2;
            buttonInfo_VAN.Text = "?";
            buttonInfo_VAN.UseVisualStyleBackColor = true;
            buttonInfo_VAN.Click += buttonInfo_Click;
            // 
            // textBoxRes_VAN
            // 
            textBoxRes_VAN.Location = new Point(743, 506);
            textBoxRes_VAN.Multiline = true;
            textBoxRes_VAN.Name = "textBoxRes_VAN";
            textBoxRes_VAN.ReadOnly = true;
            textBoxRes_VAN.Size = new Size(290, 57);
            textBoxRes_VAN.TabIndex = 3;
            textBoxRes_VAN.Text = "\r\n";
            textBoxRes_VAN.TextChanged += textBoxRes;
            // 
            // textBoxPer_VAN
            // 
            textBoxPer_VAN.Location = new Point(31, 506);
            textBoxPer_VAN.Multiline = true;
            textBoxPer_VAN.Name = "textBoxPer_VAN";
            textBoxPer_VAN.Size = new Size(226, 57);
            textBoxPer_VAN.TabIndex = 4;
            textBoxPer_VAN.KeyPress += textBoxPer_KeyPress;
            // 
            // pictureBoxFormula_VAN
            // 
            pictureBoxFormula_VAN.Image = Properties.Resources.Снимок_экрана_2025_12_07_143613;
            pictureBoxFormula_VAN.Location = new Point(751, 56);
            pictureBoxFormula_VAN.Name = "pictureBoxFormula_VAN";
            pictureBoxFormula_VAN.Size = new Size(257, 133);
            pictureBoxFormula_VAN.TabIndex = 5;
            pictureBoxFormula_VAN.TabStop = false;
            // 
            // groupBoxTask_VAN
            // 
            groupBoxTask_VAN.Controls.Add(labelWhatNeed_VAN);
            groupBoxTask_VAN.Controls.Add(pictureBoxFormula_VAN);
            groupBoxTask_VAN.Location = new Point(12, 24);
            groupBoxTask_VAN.Name = "groupBoxTask_VAN";
            groupBoxTask_VAN.Size = new Size(1067, 374);
            groupBoxTask_VAN.TabIndex = 6;
            groupBoxTask_VAN.TabStop = false;
            groupBoxTask_VAN.Text = "Условие";
            groupBoxTask_VAN.TextChanged += Условие;
            groupBoxTask_VAN.Enter += Условие;
            // 
            // labelWhatNeed_VAN
            // 
            labelWhatNeed_VAN.AutoSize = true;
            labelWhatNeed_VAN.Location = new Point(0, 79);
            labelWhatNeed_VAN.Name = "labelWhatNeed_VAN";
            labelWhatNeed_VAN.Size = new Size(409, 32);
            labelWhatNeed_VAN.TabIndex = 6;
            labelWhatNeed_VAN.Text = "Вычислить выражение по формуле";
            labelWhatNeed_VAN.Click += label5_Click;
            // 
            // labelPer_VAN
            // 
            labelPer_VAN.AutoSize = true;
            labelPer_VAN.Location = new Point(60, 459);
            labelPer_VAN.Name = "labelPer_VAN";
            labelPer_VAN.Size = new Size(176, 32);
            labelPer_VAN.TabIndex = 6;
            labelPer_VAN.Text = "Переменная x:";
            labelPer_VAN.Click += label1_Click;
            // 
            // labelVvod_VAN
            // 
            labelVvod_VAN.AutoSize = true;
            labelVvod_VAN.Location = new Point(71, 401);
            labelVvod_VAN.Name = "labelVvod_VAN";
            labelVvod_VAN.Size = new Size(156, 32);
            labelVvod_VAN.TabIndex = 7;
            labelVvod_VAN.Text = "Ввод данных";
            // 
            // labelRes_VAN
            // 
            labelRes_VAN.AutoSize = true;
            labelRes_VAN.Location = new Point(820, 459);
            labelRes_VAN.Name = "labelRes_VAN";
            labelRes_VAN.Size = new Size(125, 32);
            labelRes_VAN.TabIndex = 8;
            labelRes_VAN.Text = "Результат:";
            // 
            // labelVivod_VAN
            // 
            labelVivod_VAN.AutoSize = true;
            labelVivod_VAN.Location = new Point(802, 401);
            labelVivod_VAN.Name = "labelVivod_VAN";
            labelVivod_VAN.Size = new Size(173, 32);
            labelVivod_VAN.TabIndex = 9;
            labelVivod_VAN.Text = "Вывод данных";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 648);
            Controls.Add(labelVivod_VAN);
            Controls.Add(labelRes_VAN);
            Controls.Add(labelVvod_VAN);
            Controls.Add(labelPer_VAN);
            Controls.Add(groupBoxTask_VAN);
            Controls.Add(textBoxPer_VAN);
            Controls.Add(textBoxRes_VAN);
            Controls.Add(buttonInfo_VAN);
            Controls.Add(buttonDone_VAN);
            Name = "FormMain";
            Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_VAN).EndInit();
            groupBoxTask_VAN.ResumeLayout(false);
            groupBoxTask_VAN.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone_VAN;
        private Button buttonInfo_VAN;
        private TextBox textBoxRes_VAN;
        private TextBox textBoxPer_VAN;
        private PictureBox pictureBoxFormula_VAN;
        private GroupBox groupBoxTask_VAN;
        private Label labelPer_VAN;
        private Label labelVvod_VAN;
        private Label labelWhatNeed_VAN;
        private Label labelRes_VAN;
        private Label labelVivod_VAN;
    }
}
