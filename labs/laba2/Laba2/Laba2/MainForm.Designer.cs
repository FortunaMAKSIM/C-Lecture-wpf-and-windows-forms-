namespace Laba2
{
    partial class MainForm
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
            LogBtn = new Button();
            RegBtn = new Button();
            SuspendLayout();
            // 
            // LogBtn
            // 
            LogBtn.Location = new Point(156, 203);
            LogBtn.Name = "LogBtn";
            LogBtn.Size = new Size(200, 100);
            LogBtn.TabIndex = 0;
            LogBtn.Text = "Login";
            LogBtn.UseVisualStyleBackColor = true;
            LogBtn.Click += LogBtn_Click;
            // 
            // RegBtn
            // 
            RegBtn.Location = new Point(398, 203);
            RegBtn.Name = "RegBtn";
            RegBtn.Size = new Size(200, 100);
            RegBtn.TabIndex = 1;
            RegBtn.Text = "Register";
            RegBtn.UseVisualStyleBackColor = true;
            RegBtn.Click += button2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RegBtn);
            Controls.Add(LogBtn);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button LogBtn;
        private Button RegBtn;
    }
}