using laba3.Service.Interface;
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
    public partial class ProductsForm : Form
    {
        private readonly IDbWorker _db;
        public ProductsForm(IDbWorker db)
        {
            InitializeComponent();
            _db = db;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            dgvProd.DataSource = _db.Products;
            dgvProd.Columns["Material"].Visible = false;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            _db.SaveChanges();
        }
    }
}
