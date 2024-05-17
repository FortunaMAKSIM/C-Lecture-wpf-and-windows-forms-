namespace laba3
{
    partial class MainForm
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
            prodBtn = new Button();
            matBtn = new Button();
            CustMatBtn = new Button();
            CustProdBtn = new Button();
            SuspendLayout();
            // 
            // prodBtn
            // 
            prodBtn.Location = new Point(12, 12);
            prodBtn.Name = "prodBtn";
            prodBtn.Size = new Size(64, 67);
            prodBtn.TabIndex = 0;
            prodBtn.Text = "Products";
            prodBtn.UseVisualStyleBackColor = true;
            prodBtn.Click += prodBtn_Click;
            // 
            // matBtn
            // 
            matBtn.Location = new Point(85, 12);
            matBtn.Name = "matBtn";
            matBtn.Size = new Size(64, 67);
            matBtn.TabIndex = 1;
            matBtn.Text = "Materials";
            matBtn.UseVisualStyleBackColor = true;
            matBtn.Click += matBtn_Click;
            // 
            // CustMatBtn
            // 
            CustMatBtn.Location = new Point(85, 85);
            CustMatBtn.Name = "CustMatBtn";
            CustMatBtn.Size = new Size(64, 67);
            CustMatBtn.TabIndex = 3;
            CustMatBtn.Text = "MaterialsCustom";
            CustMatBtn.UseVisualStyleBackColor = true;
            CustMatBtn.Click += CustMatBtn_Click;
            // 
            // CustProdBtn
            // 
            CustProdBtn.Location = new Point(12, 85);
            CustProdBtn.Name = "CustProdBtn";
            CustProdBtn.Size = new Size(64, 67);
            CustProdBtn.TabIndex = 2;
            CustProdBtn.Text = "ProductsCustom";
            CustProdBtn.UseVisualStyleBackColor = true;
            CustProdBtn.Click += CustProdBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(161, 162);
            Controls.Add(CustMatBtn);
            Controls.Add(CustProdBtn);
            Controls.Add(matBtn);
            Controls.Add(prodBtn);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button prodBtn;
        private Button matBtn;
        private Button CustMatBtn;
        private Button CustProdBtn;
    }
}
