namespace laba3
{
    partial class ProductsForm
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
            saveBtn = new Button();
            dgvProd = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProd).BeginInit();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(12, 12);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 0;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // dgvProd
            // 
            dgvProd.AllowUserToAddRows = false;
            dgvProd.AllowUserToDeleteRows = false;
            dgvProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProd.Location = new Point(12, 41);
            dgvProd.Name = "dgvProd";
            dgvProd.Size = new Size(776, 397);
            dgvProd.TabIndex = 1;
            dgvProd.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProd);
            Controls.Add(saveBtn);
            Name = "ProductsForm";
            Text = "Products";
            Load += ProductsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button saveBtn;
        private DataGridView dgvProd;
    }
}