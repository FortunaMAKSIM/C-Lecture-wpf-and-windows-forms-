namespace laba3
{
    partial class MaterialView
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbID = new TextBox();
            tbName = new TextBox();
            moveBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 10);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 10);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 10);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Products";
            // 
            // tbID
            // 
            tbID.Location = new Point(3, 28);
            tbID.Name = "tbID";
            tbID.Size = new Size(100, 23);
            tbID.TabIndex = 3;
            // 
            // tbName
            // 
            tbName.Location = new Point(109, 28);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 4;
            // 
            // moveBtn
            // 
            moveBtn.Location = new Point(230, 28);
            moveBtn.Name = "moveBtn";
            moveBtn.Size = new Size(83, 23);
            moveBtn.TabIndex = 5;
            moveBtn.Text = "Move to";
            moveBtn.UseVisualStyleBackColor = true;
            moveBtn.Click += moveBtn_Click;
            // 
            // MaterialView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(moveBtn);
            Controls.Add(tbName);
            Controls.Add(tbID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MaterialView";
            Size = new Size(316, 70);
            Load += MaterialView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbID;
        private TextBox tbName;
        private Button moveBtn;
    }
}
