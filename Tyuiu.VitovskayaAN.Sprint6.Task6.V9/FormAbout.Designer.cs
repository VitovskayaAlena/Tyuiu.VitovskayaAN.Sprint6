namespace Tyuiu.VitovskayaAN.Sprint6.Task6.V9
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            labelInfo_VAN = new Label();
            buttonClose_VAN = new Button();
            SuspendLayout();
            // 
            // labelInfo_VAN
            // 
            labelInfo_VAN.AutoSize = true;
            labelInfo_VAN.Location = new Point(46, 33);
            labelInfo_VAN.Name = "labelInfo_VAN";
            labelInfo_VAN.Size = new Size(587, 288);
            labelInfo_VAN.TabIndex = 0;
            labelInfo_VAN.Text = resources.GetString("labelInfo_VAN.Text");
            // 
            // buttonClose_VAN
            // 
            buttonClose_VAN.BackColor = SystemColors.ButtonShadow;
            buttonClose_VAN.Location = new Point(664, 341);
            buttonClose_VAN.Name = "buttonClose_VAN";
            buttonClose_VAN.Size = new Size(150, 46);
            buttonClose_VAN.TabIndex = 1;
            buttonClose_VAN.Text = "ОК";
            buttonClose_VAN.UseVisualStyleBackColor = false;
            buttonClose_VAN.Click += buttonClose_VAN_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 399);
            Controls.Add(buttonClose_VAN);
            Controls.Add(labelInfo_VAN);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo_VAN;
        private Button buttonClose_VAN;
    }
}