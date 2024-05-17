using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using WinFormsApp.Services.Interfaces;

namespace Laba2
{
    public partial class RegisterDialog : Form
    {
        private readonly IDbWorker _dbWorker;

        public RegisterDialog(IDbWorker dbWorker)
        {
            InitializeComponent();
            _dbWorker = dbWorker;
        }

        private void RegisterDialog_Load(object sender, EventArgs e)
        {

        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            var login = tbLog.Text;
            var password = tbPass.Text;
            var passwordAgain = tbPassA.Text;

            if (password != passwordAgain)
            {
                MessageBox.Show("Пароли не совпадают!");
                return;
            }

            if (_dbWorker.IsLoginAlreadyTaken(login))
            {
                MessageBox.Show("Такой логин уже занят!");
                return;
            }

            _dbWorker.RegisterNewUser(login, password);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
