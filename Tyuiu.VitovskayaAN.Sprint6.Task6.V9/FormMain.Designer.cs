namespace Tyuiu.VitovskayaAN.Sprint6.Task6.V9
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
            groupBoxIcon_VAN = new GroupBox();
            buttonInfo_VAN = new Button();
            buttonDone_VAN = new Button();
            buttonOpenFile_VAN = new Button();
            openFileDialog_VAN = new OpenFileDialog();
            toolTip_VAN = new ToolTip(components);
            textBoxTask_VAN = new TextBox();
            labelTask_VAN = new Label();
            panelVvod_VAN = new Panel();
            textBoxVvod_VAN = new TextBox();
            labelVvod_VAN = new Label();
            panelVivod_VAN = new Panel();
            textBoxVivod_VAN = new TextBox();
            labelVivod_VAN = new Label();
            splitter1 = new Splitter();
            groupBoxIcon_VAN.SuspendLayout();
            panelVvod_VAN.SuspendLayout();
            panelVivod_VAN.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxIcon_VAN
            // 
            groupBoxIcon_VAN.Controls.Add(buttonInfo_VAN);
            groupBoxIcon_VAN.Controls.Add(buttonDone_VAN);
            groupBoxIcon_VAN.Controls.Add(buttonOpenFile_VAN);
            groupBoxIcon_VAN.Dock = DockStyle.Top;
            groupBoxIcon_VAN.Location = new Point(0, 0);
            groupBoxIcon_VAN.Name = "groupBoxIcon_VAN";
            groupBoxIcon_VAN.Size = new Size(1978, 156);
            groupBoxIcon_VAN.TabIndex = 0;
            groupBoxIcon_VAN.TabStop = false;
            // 
            // buttonInfo_VAN
            // 
            buttonInfo_VAN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo_VAN.BackgroundImage = Properties.Resources.help;
            buttonInfo_VAN.Location = new Point(1814, 27);
            buttonInfo_VAN.Name = "buttonInfo_VAN";
            buttonInfo_VAN.Size = new Size(125, 122);
            buttonInfo_VAN.TabIndex = 2;
            toolTip_VAN.SetToolTip(buttonInfo_VAN, "Сведение о пользователе");
            buttonInfo_VAN.UseVisualStyleBackColor = true;
            buttonInfo_VAN.Click += buttonHelp_VAN_Click;
            // 
            // buttonDone_VAN
            // 
            buttonDone_VAN.Anchor = AnchorStyles.Top;
            buttonDone_VAN.BackgroundImage = Properties.Resources.page_go;
            buttonDone_VAN.Location = new Point(164, 27);
            buttonDone_VAN.Name = "buttonDone_VAN";
            buttonDone_VAN.Size = new Size(122, 122);
            buttonDone_VAN.TabIndex = 1;
            toolTip_VAN.SetToolTip(buttonDone_VAN, "Выводит последнее слово каждой строки, \r\nконвертируя все в одну строчку");
            buttonDone_VAN.UseVisualStyleBackColor = true;
            buttonDone_VAN.Click += buttonDone_VAN_Click;
            // 
            // buttonOpenFile_VAN
            // 
            buttonOpenFile_VAN.BackgroundImage = (Image)resources.GetObject("buttonOpenFile_VAN.BackgroundImage");
            buttonOpenFile_VAN.Location = new Point(10, 27);
            buttonOpenFile_VAN.Name = "buttonOpenFile_VAN";
            buttonOpenFile_VAN.Size = new Size(132, 122);
            buttonOpenFile_VAN.TabIndex = 0;
            toolTip_VAN.SetToolTip(buttonOpenFile_VAN, "Открыть файл \r\nВыберите нужный файл для обработки\r\n");
            buttonOpenFile_VAN.UseVisualStyleBackColor = true;
            buttonOpenFile_VAN.Click += buttonOpen_VAN_Click;
            // 
            // openFileDialog_VAN
            // 
            openFileDialog_VAN.FileName = "openFileDialog1";
            // 
            // toolTip_VAN
            // 
            toolTip_VAN.ToolTipIcon = ToolTipIcon.Info;
            toolTip_VAN.ToolTipTitle = "Подсказка";
            // 
            // textBoxTask_VAN
            // 
            textBoxTask_VAN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxTask_VAN.Location = new Point(2, 180);
            textBoxTask_VAN.Multiline = true;
            textBoxTask_VAN.Name = "textBoxTask_VAN";
            textBoxTask_VAN.ReadOnly = true;
            textBoxTask_VAN.Size = new Size(1954, 114);
            textBoxTask_VAN.TabIndex = 1;
            textBoxTask_VAN.Tag = "Условие";
            textBoxTask_VAN.Text = resources.GetString("textBoxTask_VAN.Text");
            // 
            // labelTask_VAN
            // 
            labelTask_VAN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelTask_VAN.AutoSize = true;
            labelTask_VAN.Location = new Point(8, 149);
            labelTask_VAN.Name = "labelTask_VAN";
            labelTask_VAN.Size = new Size(106, 32);
            labelTask_VAN.TabIndex = 2;
            labelTask_VAN.Text = "Условие";
            // 
            // panelVvod_VAN
            // 
            panelVvod_VAN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelVvod_VAN.Controls.Add(textBoxVvod_VAN);
            panelVvod_VAN.Controls.Add(labelVvod_VAN);
            panelVvod_VAN.Location = new Point(2, 300);
            panelVvod_VAN.Name = "panelVvod_VAN";
            panelVvod_VAN.Size = new Size(958, 856);
            panelVvod_VAN.TabIndex = 3;
            // 
            // textBoxVvod_VAN
            // 
            textBoxVvod_VAN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxVvod_VAN.Location = new Point(14, 32);
            textBoxVvod_VAN.Multiline = true;
            textBoxVvod_VAN.Name = "textBoxVvod_VAN";
            textBoxVvod_VAN.ScrollBars = ScrollBars.Vertical;
            textBoxVvod_VAN.Size = new Size(932, 573);
            textBoxVvod_VAN.TabIndex = 6;
            // 
            // labelVvod_VAN
            // 
            labelVvod_VAN.AutoSize = true;
            labelVvod_VAN.Location = new Point(10, -3);
            labelVvod_VAN.Name = "labelVvod_VAN";
            labelVvod_VAN.Size = new Size(73, 32);
            labelVvod_VAN.TabIndex = 5;
            labelVvod_VAN.Text = "Ввод:";
            // 
            // panelVivod_VAN
            // 
            panelVivod_VAN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelVivod_VAN.Controls.Add(textBoxVivod_VAN);
            panelVivod_VAN.Controls.Add(labelVivod_VAN);
            panelVivod_VAN.Controls.Add(splitter1);
            panelVivod_VAN.Location = new Point(954, 305);
            panelVivod_VAN.Name = "panelVivod_VAN";
            panelVivod_VAN.Size = new Size(1002, 871);
            panelVivod_VAN.TabIndex = 4;
            // 
            // textBoxVivod_VAN
            // 
            textBoxVivod_VAN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxVivod_VAN.Location = new Point(7, 32);
            textBoxVivod_VAN.Multiline = true;
            textBoxVivod_VAN.Name = "textBoxVivod_VAN";
            textBoxVivod_VAN.ScrollBars = ScrollBars.Vertical;
            textBoxVivod_VAN.Size = new Size(975, 573);
            textBoxVivod_VAN.TabIndex = 7;
            // 
            // labelVivod_VAN
            // 
            labelVivod_VAN.AutoSize = true;
            labelVivod_VAN.Location = new Point(12, 0);
            labelVivod_VAN.Name = "labelVivod_VAN";
            labelVivod_VAN.Size = new Size(90, 32);
            labelVivod_VAN.TabIndex = 1;
            labelVivod_VAN.Text = "Вывод:";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(6, 871);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1978, 916);
            Controls.Add(panelVivod_VAN);
            Controls.Add(panelVvod_VAN);
            Controls.Add(labelTask_VAN);
            Controls.Add(textBoxTask_VAN);
            Controls.Add(groupBoxIcon_VAN);
            MinimumSize = new Size(2004, 987);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Tаск 6 | Вариант 9 | Витовская А. Н.";
            groupBoxIcon_VAN.ResumeLayout(false);
            panelVvod_VAN.ResumeLayout(false);
            panelVvod_VAN.PerformLayout();
            panelVivod_VAN.ResumeLayout(false);
            panelVivod_VAN.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxIcon_VAN;
        private Button buttonInfo_VAN;
        private Button buttonDone_VAN;
        private ToolTip toolTip_VAN;
        private OpenFileDialog openFileDialog_VAN;
        private TextBox textBoxTask_VAN;
        private Label labelTask_VAN;
        private Button buttonOpenFile_VAN;
        private Panel panelVvod_VAN;
        private Label labelVvod_VAN;
        private Panel panelVivod_VAN;
        private Splitter splitter1;
        private Label labelVivod_VAN;
        private TextBox textBoxVvod_VAN;
        private TextBox textBoxVivod_VAN;
    }
}
