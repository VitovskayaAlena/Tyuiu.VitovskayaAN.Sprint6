namespace Tyuiu.VitovskayaAN.Sprint6.Task7.V11
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
            label1 = new Label();
            buttonOK_VAN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 24);
            label1.Name = "label1";
            label1.Size = new Size(600, 320);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // buttonOK_VAN
            // 
            buttonOK_VAN.Location = new Point(610, 377);
            buttonOK_VAN.Name = "buttonOK_VAN";
            buttonOK_VAN.Size = new Size(150, 46);
            buttonOK_VAN.TabIndex = 1;
            buttonOK_VAN.Text = "OK";
            buttonOK_VAN.UseVisualStyleBackColor = true;
            buttonOK_VAN.Click += buttonOK_VAN_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOK_VAN);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonOK_VAN;
    }
}