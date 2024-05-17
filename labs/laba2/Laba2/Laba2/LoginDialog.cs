using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Services.Interfaces;

namespace Laba2
{
    public partial class LoginDialog : Form
    {
        private readonly IDbWorker _dbWorker;

        public LoginDialog(IDbWorker dbWorker)
        {
            InitializeComponent();
            _dbWorker = dbWorker;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var login = tbLog.Text;
            var password = tbPass.Text;

            var isSuccessful = _dbWorker.Authenticate(login, password);

            if (isSuccessful)
            {
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            MessageBox.Show("Не правильный логин или пароль");
        }
    }
}
