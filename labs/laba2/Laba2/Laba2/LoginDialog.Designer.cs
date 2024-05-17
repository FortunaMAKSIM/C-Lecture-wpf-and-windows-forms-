namespace Laba2
{
    partial class LoginDialog
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
            tbLog = new TextBox();
            tbPass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            LoginBtn = new Button();
            SuspendLayout();
            // 
            // tbLog
            // 
            tbLog.Location = new Point(305, 133);
            tbLog.Name = "tbLog";
            tbLog.Size = new Size(189, 23);
            tbLog.TabIndex = 0;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(324, 162);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(170, 23);
            tbPass.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(262, 136);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 165);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(412, 203);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(82, 43);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // LoginDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPass);
            Controls.Add(tbLog);
            Name = "LoginDialog";
            Text = "LoginDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbLog;
        private TextBox tbPass;
        private Label label1;
        private Label label2;
        private Button LoginBtn;
    }
}