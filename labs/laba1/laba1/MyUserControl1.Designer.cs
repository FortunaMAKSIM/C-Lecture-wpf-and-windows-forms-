namespace laba1
{
    partial class MyUserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            tbPassword = new TextBox();
            btnShowPassword = new Button();
            SuspendLayout();
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPassword.Location = new Point(3, 3);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(166, 23);
            tbPassword.TabIndex = 0;
            tbPassword.TextChanged += textBox1_TextChanged;
            // 
            // btnShowPassword
            // 
            btnShowPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShowPassword.Location = new Point(175, 3);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(23, 23);
            btnShowPassword.TabIndex = 1;
            btnShowPassword.Text = "👀";
            btnShowPassword.UseVisualStyleBackColor = true;
            btnShowPassword.Click += button1_Click;
            // 
            // MyUserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnShowPassword);
            Controls.Add(tbPassword);
            MaximumSize = new Size(210, 50);
            Name = "MyUserControl1";
            Size = new Size(203, 44);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPassword;
        private Button btnShowPassword;
    }
}
