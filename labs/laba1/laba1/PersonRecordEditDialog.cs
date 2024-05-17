using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace laba1
{
    public partial class PersonRecordEditDialog : Form
    {
        public PersonRecordEditDialog()
        {
            InitializeComponent();
        }

        private void PersonRecordEditDialog_Load(object sender, EventArgs e)
        {

        }
        public string Name { get; private set; }
        public string SecondName { get; private set; }
        public string ThirdName { get; private set; }
        public string Age { get; private set; }
        public void PersonInfo(string name, string secondName, string thirdName, string age)
        {
            textBox2.Text = name;
            textBox3.Text = secondName;
            textBox4.Text = thirdName;
            textBox5.Text = age;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Name = textBox2.Text;
            SecondName = textBox3.Text;
            ThirdName = textBox4.Text;
            Age = textBox5.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
