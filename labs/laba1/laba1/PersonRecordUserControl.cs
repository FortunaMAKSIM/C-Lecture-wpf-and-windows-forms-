using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1
{
    public partial class PersonRecordUserControl : UserControl
    {
        public PersonRecordUserControl()
        {
            InitializeComponent();
        }
        public int Age
        {
            get { return int.Parse(textBox5.Text); }
        }
        public void PersonInfo(int id)
        {
            textBox1.Text = id.ToString();
        }
        public FlowLayoutPanel FlowPanel { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            PersonRecordEditDialog dialogForm = new PersonRecordEditDialog();
            dialogForm.PersonInfo(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            MessageBox.Show($"{dialogForm.DialogResult}");
            if (dialogForm.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dialogForm.Name;
                textBox3.Text = dialogForm.SecondName;
                textBox4.Text = dialogForm.ThirdName;
                textBox5.Text = dialogForm.Age;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (FlowPanel != null)
            {
                int index = FlowPanel.Controls.IndexOf(this);
                FlowPanel.Controls.Remove(this);
                //Stats();
            }
        }
    }
}
