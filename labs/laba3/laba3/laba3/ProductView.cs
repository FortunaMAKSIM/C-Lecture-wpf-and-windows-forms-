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
    public partial class ProductView : UserControl
    {
        public ProductView()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProductView_Load(object sender, EventArgs e)
        {

        }
        public int ProductId
        {
            get { return int.Parse(tbID.Text); }
            set { tbID.Text = value.ToString(); }
        }

        public string ProductName
        {
            get { return tbName.Text; }
            set { tbName.Text = value; }
        }

        public int ProductPrice
        {
            get { return int.Parse(tbPrice.Text); }
            set { tbPrice.Text = value.ToString(); }
        }

        public string SelectedMaterial
        {
            get { return cbMaterial.SelectedItem.ToString(); }
            set { cbMaterial.SelectedItem = value; }
        }

        public void LoadMaterials(IEnumerable<string> materials)
        {
            cbMaterial.Items.Clear();
            foreach (var material in materials)
            {
                cbMaterial.Items.Add(material);
            }
        }
    }
}
