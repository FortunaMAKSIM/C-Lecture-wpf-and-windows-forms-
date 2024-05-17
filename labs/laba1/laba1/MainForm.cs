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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        //int tPersons = 0;
        //int tAge = 0;
        //private void Stats()
        //{
        //    tPersons = flowLayoutPanel1.Controls.Count;
        //    tAge = 0;
        //    foreach (PersonRecordUserControl control in flowLayoutPanel1.Controls)
        //    {
        //        tAge += control.Age;
        //    }
        //    textBox1.Text = tPersons.ToString();
        //    textBox2.Text = tAge.ToString();   
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            PersonRecordUserControl personRecord = new();
            int nextId = GenerId();
            personRecord.FlowPanel = flowLayoutPanel1;
            personRecord.PersonInfo(nextId);
            flowLayoutPanel1.Controls.Add(personRecord);
            //Stats();

        }
        private int GenerId()
        {
            int PersonCount = flowLayoutPanel1.Controls.Count;
            return PersonCount + 1;
        }
    }
}
