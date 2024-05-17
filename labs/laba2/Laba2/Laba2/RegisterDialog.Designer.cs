namespace Laba2
{
    partial class RegisterDialog
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
            RegBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            tbPass = new TextBox();
            tbLog = new TextBox();
            label3 = new Label();
            tbPassA = new TextBox();
            SuspendLayout();
            // 
            // RegBtn
            // 
            RegBtn.Location = new Point(411, 248);
            RegBtn.Name = "RegBtn";
            RegBtn.Size = new Size(82, 43);
            RegBtn.TabIndex = 9;
            RegBtn.Text = "Register";
            RegBtn.UseVisualStyleBackColor = true;
            RegBtn.Click += RegBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 193);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 164);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 7;
            label1.Text = "Login";
            // 
            // tbPass
            // 
            tbPass.Location = new Point(323, 190);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(170, 23);
            tbPass.TabIndex = 6;
            // 
            // tbLog
            // 
            tbLog.Location = new Point(304, 161);
            tbLog.Name = "tbLog";
            tbLog.Size = new Size(189, 23);
            tbLog.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(261, 222);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // tbPassA
            // 
            tbPassA.Location = new Point(323, 219);
            tbPassA.Name = "tbPassA";
            tbPassA.Size = new Size(170, 23);
            tbPassA.TabIndex = 10;
            // 
            // RegisterDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(tbPassA);
            Controls.Add(RegBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPass);
            Controls.Add(tbLog);
            Name = "RegisterDialog";
            Text = "RegisterDialog";
            Load += RegisterDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegBtn;
        private Label label2;
        private Label label1;
        private TextBox tbPass;
        private TextBox tbLog;
        private Label label3;
        private TextBox tbPassA;
    }
}