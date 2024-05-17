using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3
{
    public partial class MaterialView : UserControl
    {
        public event EventHandler<int> ProductsButtonClicked;
        public MaterialView()
        {
            InitializeComponent();
        }

        private void MaterialView_Load(object sender, EventArgs e)
        {

        }

        private void moveBtn_Click(object sender, EventArgs e)
        {
            int materialId = int.Parse(tbID.Text);


            ProductsButtonClicked?.Invoke(this, materialId);
        }

        public int MaterialId
        {
            get { return int.Parse(tbID.Text); }
            set { tbID.Text = value.ToString(); }
        }

        public string MaterialName
        {
            get { return tbName.Text; }
            set { tbName.Text = value; }
        }
    }
}
