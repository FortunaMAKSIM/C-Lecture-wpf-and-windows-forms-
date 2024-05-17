using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace Laba2
{
    public partial class MainForm : Form
    {

        private readonly IServiceProvider _serviceProvider;

        public MainForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            var LD = _serviceProvider.GetRequiredService<LoginDialog>();

            if (LD.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Успешно");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var RD = _serviceProvider.GetRequiredService<RegisterDialog>();

            if (RD.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Успешно");
            }
        }
    }
}
