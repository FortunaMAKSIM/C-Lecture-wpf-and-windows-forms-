namespace laba3
{
    partial class CustomProductsForm
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
            flpProducts = new FlowLayoutPanel();
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
            // flpProducts
            // 
            flpProducts.Location = new Point(12, 41);
            flpProducts.Name = "flpProducts";
            flpProducts.Size = new Size(776, 397);
            flpProducts.TabIndex = 1;
            // 
            // CustomProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flpProducts);
            Controls.Add(saveBtn);
            Name = "CustomProductsForm";
            Text = "CustomProductsForm";
            Load += CustomProductsForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button saveBtn;
        private FlowLayoutPanel flpProducts;
    }
}