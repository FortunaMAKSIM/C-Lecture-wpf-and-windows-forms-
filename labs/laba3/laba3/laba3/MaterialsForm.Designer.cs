
namespace laba3
{
    partial class MaterialsForm
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
            dgvMat = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMat).BeginInit();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(12, 9);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 0;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // dgvMat
            // 
            dgvMat.AllowUserToAddRows = false;
            dgvMat.AllowUserToDeleteRows = false;
            dgvMat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMat.Location = new Point(12, 38);
            dgvMat.Name = "dgvMat";
            dgvMat.Size = new Size(776, 400);
            dgvMat.TabIndex = 1;
            dgvMat.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MaterialsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMat);
            Controls.Add(saveBtn);
            Name = "MaterialsForm";
            Text = "Materials";
            Load += MaterialsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button saveBtn;
        private DataGridView dgvMat;
    }
}