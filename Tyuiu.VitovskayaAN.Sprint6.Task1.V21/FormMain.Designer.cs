namespace Tyuiu.VitovskayaAN.Sprint6.Task1.V21
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
            components = new System.ComponentModel.Container();
            textBoxStart_VAN = new TextBox();
            textBoxStop_VAN = new TextBox();
            textBoxTask = new TextBox();
            groupBoxResult_VAN = new GroupBox();
            textBoxResult = new TextBox();
            buttonDone_VAN = new Button();
            buttonHelp_VAN = new Button();
            groupBoxVvod_VAN = new GroupBox();
            labelStop = new Label();
            labelStart_VAN = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBoxResult_VAN.SuspendLayout();
            groupBoxVvod_VAN.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxStart_VAN
            // 
            textBoxStart_VAN.Location = new Point(16, 124);
            textBoxStart_VAN.Name = "textBoxStart_VAN";
            textBoxStart_VAN.Size = new Size(200, 39);
            textBoxStart_VAN.TabIndex = 0;
            // 
            // textBoxStop_VAN
            // 
            textBoxStop_VAN.Location = new Point(369, 124);
            textBoxStop_VAN.Name = "textBoxStop_VAN";
            textBoxStop_VAN.Size = new Size(200, 39);
            textBoxStop_VAN.TabIndex = 1;
            textBoxStop_VAN.TextChanged += textBoxStop_VAN_TextChanged;
            // 
            // textBoxTask
            // 
            textBoxTask.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask.Location = new Point(12, 12);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(1015, 448);
            textBoxTask.TabIndex = 3;
            textBoxTask.Text = "Условие\r\n\r\nПротабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы.";
            // 
            // groupBoxResult_VAN
            // 
            groupBoxResult_VAN.Controls.Add(textBoxResult);
            groupBoxResult_VAN.Location = new Point(1033, 24);
            groupBoxResult_VAN.Name = "groupBoxResult_VAN";
            groupBoxResult_VAN.Size = new Size(484, 716);
            groupBoxResult_VAN.TabIndex = 4;
            groupBoxResult_VAN.TabStop = false;
            groupBoxResult_VAN.Text = "Вывод данных                             Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(6, 71);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(451, 639);
            textBoxResult.TabIndex = 0;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // buttonDone_VAN
            // 
            buttonDone_VAN.BackColor = Color.Green;
            buttonDone_VAN.Location = new Point(813, 606);
            buttonDone_VAN.Name = "buttonDone_VAN";
            buttonDone_VAN.Size = new Size(214, 116);
            buttonDone_VAN.TabIndex = 5;
            buttonDone_VAN.Text = "Выполнить";
            buttonDone_VAN.UseVisualStyleBackColor = false;
            buttonDone_VAN.Click += buttonDone_VAN_Click;
            // 
            // buttonHelp_VAN
            // 
            buttonHelp_VAN.BackColor = SystemColors.ActiveCaption;
            buttonHelp_VAN.Location = new Point(625, 606);
            buttonHelp_VAN.Name = "buttonHelp_VAN";
            buttonHelp_VAN.Size = new Size(171, 116);
            buttonHelp_VAN.TabIndex = 6;
            buttonHelp_VAN.Text = "Справка";
            buttonHelp_VAN.UseVisualStyleBackColor = false;
            buttonHelp_VAN.Click += buttonHelp_VAN_Click;
            // 
            // groupBoxVvod_VAN
            // 
            groupBoxVvod_VAN.Controls.Add(labelStop);
            groupBoxVvod_VAN.Controls.Add(labelStart_VAN);
            groupBoxVvod_VAN.Controls.Add(textBoxStart_VAN);
            groupBoxVvod_VAN.Controls.Add(textBoxStop_VAN);
            groupBoxVvod_VAN.Location = new Point(6, 466);
            groupBoxVvod_VAN.Name = "groupBoxVvod_VAN";
            groupBoxVvod_VAN.Size = new Size(613, 262);
            groupBoxVvod_VAN.TabIndex = 7;
            groupBoxVvod_VAN.TabStop = false;
            groupBoxVvod_VAN.Text = "Ввод данных";
            // 
            // labelStop
            // 
            labelStop.AutoSize = true;
            labelStop.Location = new Point(375, 74);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(147, 32);
            labelStop.TabIndex = 3;
            labelStop.Text = "Конец шага:";
            // 
            // labelStart_VAN
            // 
            labelStart_VAN.AutoSize = true;
            labelStart_VAN.Location = new Point(16, 76);
            labelStart_VAN.Name = "labelStart_VAN";
            labelStart_VAN.Size = new Size(139, 32);
            labelStart_VAN.TabIndex = 2;
            labelStart_VAN.Text = "Старт шага:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1518, 740);
            Controls.Add(groupBoxVvod_VAN);
            Controls.Add(buttonHelp_VAN);
            Controls.Add(buttonDone_VAN);
            Controls.Add(groupBoxResult_VAN);
            Controls.Add(textBoxTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "Спринт 6 | Tаск 1 | Вариант 21 | Витовская А. Н.";
            groupBoxResult_VAN.ResumeLayout(false);
            groupBoxResult_VAN.PerformLayout();
            groupBoxVvod_VAN.ResumeLayout(false);
            groupBoxVvod_VAN.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxStart_VAN;
        private TextBox textBoxStop_VAN;
        private TextBox textBoxTask;
        private GroupBox groupBoxResult_VAN;
        private TextBox textBoxResult;
        private Button buttonDone_VAN;
        private Button buttonHelp_VAN;
        private GroupBox groupBoxVvod_VAN;
        private Label labelStop;
        private Label labelStart_VAN;
        private ContextMenuStrip contextMenuStrip1;
    }
}
