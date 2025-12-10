namespace Tyuiu.VitovskayaAN.Sprint6.Task7.V11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTask_VAN = new Panel();
            groupBoxTask_VAN = new GroupBox();
            textBoxTask_VAN = new TextBox();
            buttonHelp_VAN = new Button();
            buttonSave_VAN = new Button();
            buttonDone_VAN = new Button();
            buttonOpenFile_VAN = new Button();
            groupBoxVvod_VAN = new GroupBox();
            dataGridViewVvod_VAN = new DataGridView();
            openFileDialogTask = new OpenFileDialog();
            toolTipButton = new ToolTip(components);
            saveFileDialogMatrix = new SaveFileDialog();
            groupBoxViv_VAN = new GroupBox();
            dataGridViewVivod_VAN = new DataGridView();
            panelVivod_VAN = new Panel();
            panelVvod_VAN = new Panel();
            panelTask_VAN.SuspendLayout();
            groupBoxTask_VAN.SuspendLayout();
            groupBoxVvod_VAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVvod_VAN).BeginInit();
            groupBoxViv_VAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVivod_VAN).BeginInit();
            panelVivod_VAN.SuspendLayout();
            panelVvod_VAN.SuspendLayout();
            SuspendLayout();
            // 
            // panelTask_VAN
            // 
            panelTask_VAN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTask_VAN.Controls.Add(groupBoxTask_VAN);
            panelTask_VAN.Controls.Add(buttonHelp_VAN);
            panelTask_VAN.Controls.Add(buttonSave_VAN);
            panelTask_VAN.Controls.Add(buttonDone_VAN);
            panelTask_VAN.Controls.Add(buttonOpenFile_VAN);
            panelTask_VAN.Location = new Point(0, 0);
            panelTask_VAN.Name = "panelTask_VAN";
            panelTask_VAN.Size = new Size(2022, 324);
            panelTask_VAN.TabIndex = 0;
            // 
            // groupBoxTask_VAN
            // 
            groupBoxTask_VAN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTask_VAN.Controls.Add(textBoxTask_VAN);
            groupBoxTask_VAN.Location = new Point(12, 165);
            groupBoxTask_VAN.Name = "groupBoxTask_VAN";
            groupBoxTask_VAN.Size = new Size(2007, 156);
            groupBoxTask_VAN.TabIndex = 1;
            groupBoxTask_VAN.TabStop = false;
            groupBoxTask_VAN.Text = "Условие:";
            // 
            // textBoxTask_VAN
            // 
            textBoxTask_VAN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTask_VAN.Location = new Point(3, 35);
            textBoxTask_VAN.Multiline = true;
            textBoxTask_VAN.Name = "textBoxTask_VAN";
            textBoxTask_VAN.ReadOnly = true;
            textBoxTask_VAN.Size = new Size(2001, 118);
            textBoxTask_VAN.TabIndex = 0;
            textBoxTask_VAN.Text = resources.GetString("textBoxTask_VAN.Text");
            // 
            // buttonHelp_VAN
            // 
            buttonHelp_VAN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_VAN.Cursor = Cursors.Help;
            buttonHelp_VAN.FlatStyle = FlatStyle.Flat;
            buttonHelp_VAN.ForeColor = Color.Silver;
            buttonHelp_VAN.Image = (Image)resources.GetObject("buttonHelp_VAN.Image");
            buttonHelp_VAN.Location = new Point(1840, 35);
            buttonHelp_VAN.Name = "buttonHelp_VAN";
            buttonHelp_VAN.Size = new Size(145, 109);
            buttonHelp_VAN.TabIndex = 3;
            toolTipButton.SetToolTip(buttonHelp_VAN, "Справка");
            buttonHelp_VAN.UseVisualStyleBackColor = true;
            buttonHelp_VAN.Click += buttonHelp_VAN_Click;
            // 
            // buttonSave_VAN
            // 
            buttonSave_VAN.Cursor = Cursors.Hand;
            buttonSave_VAN.Enabled = false;
            buttonSave_VAN.FlatStyle = FlatStyle.Flat;
            buttonSave_VAN.ForeColor = Color.Silver;
            buttonSave_VAN.Image = (Image)resources.GetObject("buttonSave_VAN.Image");
            buttonSave_VAN.Location = new Point(436, 35);
            buttonSave_VAN.Name = "buttonSave_VAN";
            buttonSave_VAN.Size = new Size(163, 109);
            buttonSave_VAN.TabIndex = 2;
            toolTipButton.SetToolTip(buttonSave_VAN, "Сохранить в файл");
            buttonSave_VAN.UseVisualStyleBackColor = true;
            buttonSave_VAN.Click += buttonSave_VAN_Click;
            // 
            // buttonDone_VAN
            // 
            buttonDone_VAN.Cursor = Cursors.Hand;
            buttonDone_VAN.Enabled = false;
            buttonDone_VAN.FlatStyle = FlatStyle.Flat;
            buttonDone_VAN.ForeColor = Color.Silver;
            buttonDone_VAN.Image = (Image)resources.GetObject("buttonDone_VAN.Image");
            buttonDone_VAN.Location = new Point(225, 35);
            buttonDone_VAN.Name = "buttonDone_VAN";
            buttonDone_VAN.Size = new Size(161, 109);
            buttonDone_VAN.TabIndex = 1;
            toolTipButton.SetToolTip(buttonDone_VAN, "Выполнить");
            buttonDone_VAN.UseVisualStyleBackColor = true;
            buttonDone_VAN.Click += buttonDone_VAN_Click;
            // 
            // buttonOpenFile_VAN
            // 
            buttonOpenFile_VAN.Cursor = Cursors.Hand;
            buttonOpenFile_VAN.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_VAN.ForeColor = Color.Silver;
            buttonOpenFile_VAN.Image = (Image)resources.GetObject("buttonOpenFile_VAN.Image");
            buttonOpenFile_VAN.Location = new Point(23, 35);
            buttonOpenFile_VAN.Name = "buttonOpenFile_VAN";
            buttonOpenFile_VAN.Size = new Size(168, 109);
            buttonOpenFile_VAN.TabIndex = 0;
            toolTipButton.SetToolTip(buttonOpenFile_VAN, "Выберите файл");
            buttonOpenFile_VAN.UseVisualStyleBackColor = true;
            buttonOpenFile_VAN.Click += buttonOpenFile_VAN_Click;
            // 
            // groupBoxVvod_VAN
            // 
            groupBoxVvod_VAN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxVvod_VAN.Controls.Add(dataGridViewVvod_VAN);
            groupBoxVvod_VAN.Location = new Point(6, 3);
            groupBoxVvod_VAN.Name = "groupBoxVvod_VAN";
            groupBoxVvod_VAN.Size = new Size(1039, 1054);
            groupBoxVvod_VAN.TabIndex = 0;
            groupBoxVvod_VAN.TabStop = false;
            groupBoxVvod_VAN.Text = "Ввод:";
            // 
            // dataGridViewVvod_VAN
            // 
            dataGridViewVvod_VAN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewVvod_VAN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewVvod_VAN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVvod_VAN.ColumnHeadersVisible = false;
            dataGridViewVvod_VAN.Location = new Point(-3, 38);
            dataGridViewVvod_VAN.Name = "dataGridViewVvod_VAN";
            dataGridViewVvod_VAN.ReadOnly = true;
            dataGridViewVvod_VAN.RowHeadersVisible = false;
            dataGridViewVvod_VAN.RowHeadersWidth = 82;
            dataGridViewVvod_VAN.ScrollBars = ScrollBars.None;
            dataGridViewVvod_VAN.Size = new Size(1036, 680);
            dataGridViewVvod_VAN.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // toolTipButton
            // 
            toolTipButton.ForeColor = SystemColors.Highlight;
            toolTipButton.IsBalloon = true;
            toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // groupBoxViv_VAN
            // 
            groupBoxViv_VAN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBoxViv_VAN.Controls.Add(dataGridViewVivod_VAN);
            groupBoxViv_VAN.Location = new Point(0, 6);
            groupBoxViv_VAN.Name = "groupBoxViv_VAN";
            groupBoxViv_VAN.Size = new Size(962, 1000);
            groupBoxViv_VAN.TabIndex = 1;
            groupBoxViv_VAN.TabStop = false;
            groupBoxViv_VAN.Text = "Вывод:";
            // 
            // dataGridViewVivod_VAN
            // 
            dataGridViewVivod_VAN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridViewVivod_VAN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewVivod_VAN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVivod_VAN.ColumnHeadersVisible = false;
            dataGridViewVivod_VAN.Location = new Point(3, 38);
            dataGridViewVivod_VAN.Name = "dataGridViewVivod_VAN";
            dataGridViewVivod_VAN.ReadOnly = true;
            dataGridViewVivod_VAN.RowHeadersVisible = false;
            dataGridViewVivod_VAN.RowHeadersWidth = 82;
            dataGridViewVivod_VAN.ScrollBars = ScrollBars.None;
            dataGridViewVivod_VAN.Size = new Size(953, 698);
            dataGridViewVivod_VAN.TabIndex = 0;
            // 
            // panelVivod_VAN
            // 
            panelVivod_VAN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelVivod_VAN.Controls.Add(groupBoxViv_VAN);
            panelVivod_VAN.Location = new Point(1054, 327);
            panelVivod_VAN.Name = "panelVivod_VAN";
            panelVivod_VAN.Size = new Size(965, 733);
            panelVivod_VAN.TabIndex = 3;
            // 
            // panelVvod_VAN
            // 
            panelVvod_VAN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelVvod_VAN.Controls.Add(groupBoxVvod_VAN);
            panelVvod_VAN.Location = new Point(0, 330);
            panelVvod_VAN.Name = "panelVvod_VAN";
            panelVvod_VAN.Size = new Size(1048, 730);
            panelVvod_VAN.TabIndex = 4;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2022, 1060);
            Controls.Add(panelTask_VAN);
            Controls.Add(panelVvod_VAN);
            Controls.Add(panelVivod_VAN);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Tаск 7 | Вариант 11 | Витовская А. Н.";
            panelTask_VAN.ResumeLayout(false);
            groupBoxTask_VAN.ResumeLayout(false);
            groupBoxTask_VAN.PerformLayout();
            groupBoxVvod_VAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVvod_VAN).EndInit();
            groupBoxViv_VAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVivod_VAN).EndInit();
            panelVivod_VAN.ResumeLayout(false);
            panelVvod_VAN.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTask_VAN;
        private Panel panelInput_VAN;
        private TextBox textBoxTask_VAN;
        private GroupBox groupBoxTask_VAN;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button buttonHelp_VAN;
        private Button buttonSave_VAN;
        private Button buttonDone_VAN;
        private Button buttonOpenFile_VAN;
        private GroupBox groupBoxVvod_VAN;
        private DataGridView dataGridViewVvod_VAN;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTipButton;
        private SaveFileDialog saveFileDialogMatrix;
        private GroupBox groupBoxViv_VAN;
        private DataGridView dataGridViewVivod_VAN;
        private Panel panelVivod_VAN;
        private Panel panelVvod_VAN;
    }
}
