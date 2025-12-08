namespace Tyuiu.VitovskayaAN.Sprint6.Task3.V18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_VAN = new GroupBox();
            textBoxTask_VAN = new TextBox();
            dataGridViewMatrix_VAN = new DataGridView();
            groupBoxResult_VAN = new GroupBox();
            labelResult_VAN = new Label();
            buttonDone_VAN = new Button();
            buttonHelp_VAN = new Button();
            groupBoxTask_VAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_VAN).BeginInit();
            groupBoxResult_VAN.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_VAN
            // 
            groupBoxTask_VAN.Controls.Add(textBoxTask_VAN);
            groupBoxTask_VAN.Location = new Point(12, 12);
            groupBoxTask_VAN.Name = "groupBoxTask_VAN";
            groupBoxTask_VAN.Size = new Size(654, 782);
            groupBoxTask_VAN.TabIndex = 0;
            groupBoxTask_VAN.TabStop = false;
            groupBoxTask_VAN.Text = "Условие";
            // 
            // textBoxTask_VAN
            // 
            textBoxTask_VAN.Location = new Point(0, 38);
            textBoxTask_VAN.Multiline = true;
            textBoxTask_VAN.Name = "textBoxTask_VAN";
            textBoxTask_VAN.ReadOnly = true;
            textBoxTask_VAN.Size = new Size(605, 491);
            textBoxTask_VAN.TabIndex = 0;
            textBoxTask_VAN.Text = resources.GetString("textBoxTask_VAN.Text");
            // 
            // dataGridViewMatrix_VAN
            // 
            dataGridViewMatrix_VAN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_VAN.ColumnHeadersVisible = false;
            dataGridViewMatrix_VAN.Location = new Point(23, 99);
            dataGridViewMatrix_VAN.Name = "dataGridViewMatrix_VAN";
            dataGridViewMatrix_VAN.RowHeadersVisible = false;
            dataGridViewMatrix_VAN.RowHeadersWidth = 82;
            dataGridViewMatrix_VAN.Size = new Size(658, 648);
            dataGridViewMatrix_VAN.TabIndex = 1;
            // 
            // groupBoxResult_VAN
            // 
            groupBoxResult_VAN.Controls.Add(dataGridViewMatrix_VAN);
            groupBoxResult_VAN.Controls.Add(labelResult_VAN);
            groupBoxResult_VAN.Location = new Point(689, 28);
            groupBoxResult_VAN.Name = "groupBoxResult_VAN";
            groupBoxResult_VAN.Size = new Size(741, 766);
            groupBoxResult_VAN.TabIndex = 1;
            groupBoxResult_VAN.TabStop = false;
            groupBoxResult_VAN.Text = "Вывод данных";
            // 
            // labelResult_VAN
            // 
            labelResult_VAN.AutoSize = true;
            labelResult_VAN.Location = new Point(11, 48);
            labelResult_VAN.Name = "labelResult_VAN";
            labelResult_VAN.Size = new Size(125, 32);
            labelResult_VAN.TabIndex = 0;
            labelResult_VAN.Text = "Результат:";
            // 
            // buttonDone_VAN
            // 
            buttonDone_VAN.Location = new Point(1253, 814);
            buttonDone_VAN.Name = "buttonDone_VAN";
            buttonDone_VAN.Size = new Size(177, 49);
            buttonDone_VAN.TabIndex = 1;
            buttonDone_VAN.Text = "Выполнить";
            buttonDone_VAN.UseVisualStyleBackColor = true;
            buttonDone_VAN.Click += buttonDone_VAN_Click;
            // 
            // buttonHelp_VAN
            // 
            buttonHelp_VAN.Location = new Point(1137, 814);
            buttonHelp_VAN.Name = "buttonHelp_VAN";
            buttonHelp_VAN.Size = new Size(79, 49);
            buttonHelp_VAN.TabIndex = 2;
            buttonHelp_VAN.Text = "?";
            buttonHelp_VAN.UseVisualStyleBackColor = true;
            buttonHelp_VAN.Click += buttonHelp_VAN_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 894);
            Controls.Add(buttonHelp_VAN);
            Controls.Add(buttonDone_VAN);
            Controls.Add(groupBoxResult_VAN);
            Controls.Add(groupBoxTask_VAN);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Tаск 3 | Вариант 18 | Витовская А. Н.";
            groupBoxTask_VAN.ResumeLayout(false);
            groupBoxTask_VAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_VAN).EndInit();
            groupBoxResult_VAN.ResumeLayout(false);
            groupBoxResult_VAN.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_VAN;
        private TextBox textBoxTask_VAN;
        private GroupBox groupBoxResult_VAN;
        private DataGridView dataGridViewMatrix_VAN;
        private Label labelResult_VAN;
        private Button buttonDone_VAN;
        private Button buttonHelp_VAN;
    }
}
