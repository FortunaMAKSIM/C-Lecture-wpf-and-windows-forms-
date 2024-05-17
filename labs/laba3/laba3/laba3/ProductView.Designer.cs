namespace laba3
{
    partial class ProductView
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
            label4 = new Label();
            tbID = new TextBox();
            tbName = new TextBox();
            tbPrice = new TextBox();
            cbMaterial = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 9);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 9);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 9);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(365, 9);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 3;
            label4.Text = "Material";
            // 
            // tbID
            // 
            tbID.Location = new Point(3, 27);
            tbID.Name = "tbID";
            tbID.Size = new Size(100, 23);
            tbID.TabIndex = 4;
            // 
            // tbName
            // 
            tbName.Location = new Point(112, 27);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 5;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(221, 27);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(100, 23);
            tbPrice.TabIndex = 6;
            // 
            // cbMaterial
            // 
            cbMaterial.FormattingEnabled = true;
            cbMaterial.Location = new Point(328, 27);
            cbMaterial.Name = "cbMaterial";
            cbMaterial.Size = new Size(121, 23);
            cbMaterial.TabIndex = 7;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbMaterial);
            Controls.Add(tbPrice);
            Controls.Add(tbName);
            Controls.Add(tbID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductView";
            Size = new Size(454, 70);
            Load += ProductView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbID;
        private TextBox tbName;
        private TextBox tbPrice;
        private ComboBox cbMaterial;
    }
}
