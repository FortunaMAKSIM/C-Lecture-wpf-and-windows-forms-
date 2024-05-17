using System.Windows.Forms;

namespace laba1
{
    public partial class MyForm : Form
    {
        public string Password { get => myUserControl11.Password; }
        public MyForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void myUserControl11_Load(object sender, EventArgs e)
        {

        }

        private void myComponent11_Tick(object sender, EventArgs e)
        {
            lblMyComponentText.Text = $"{DateTime.Now}";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnDialogOpen_Click(object sender, EventArgs e)
        {
            var dialogForm = new MyForm();
            dialogForm.ShowDialog();

            MessageBox.Show($"{dialogForm.DialogResult}");

            if (dialogForm.DialogResult == DialogResult.OK )
            {
                MessageBox.Show($"{dialogForm.Password}");
            }
        }
    }
}