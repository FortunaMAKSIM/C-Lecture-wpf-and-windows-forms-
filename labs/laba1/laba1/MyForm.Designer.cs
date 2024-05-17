namespace laba1
{
    partial class MyForm
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
            components = new System.ComponentModel.Container();
            myUserControl11 = new MyUserControl1();
            myComponent11 = new MyComponent1(components);
            lblMyComponentText = new Label();
            btnDialogOpen = new Button();
            btnOk = new Button();
            SuspendLayout();
            // 
            // myUserControl11
            // 
            myUserControl11.Location = new Point(12, 12);
            myUserControl11.MaximumSize = new Size(210, 50);
            myUserControl11.Name = "myUserControl11";
            myUserControl11.Password = "";
            myUserControl11.Size = new Size(203, 44);
            myUserControl11.TabIndex = 0;
            myUserControl11.Load += myUserControl11_Load;
            // 
            // myComponent11
            // 
            myComponent11.Tick += myComponent11_Tick;
            // 
            // lblMyComponentText
            // 
            lblMyComponentText.AutoSize = true;
            lblMyComponentText.Location = new Point(314, 31);
            lblMyComponentText.Name = "lblMyComponentText";
            lblMyComponentText.Size = new Size(38, 15);
            lblMyComponentText.TabIndex = 1;
            lblMyComponentText.Text = "label1";
            // 
            // btnDialogOpen
            // 
            btnDialogOpen.Location = new Point(176, 161);
            btnDialogOpen.Name = "btnDialogOpen";
            btnDialogOpen.Size = new Size(138, 69);
            btnDialogOpen.TabIndex = 2;
            btnDialogOpen.Text = "dialog open";
            btnDialogOpen.UseVisualStyleBackColor = true;
            btnDialogOpen.Click += btnDialogOpen_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(363, 167);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(139, 63);
            btnOk.TabIndex = 3;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // MyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOk);
            Controls.Add(btnDialogOpen);
            Controls.Add(lblMyComponentText);
            Controls.Add(myUserControl11);
            Name = "MyForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyUserControl1 myUserControl11;
        private MyComponent1 myComponent11;
        private Label lblMyComponentText;
        private Button btnDialogOpen;
        private Button btnOk;
    }
}