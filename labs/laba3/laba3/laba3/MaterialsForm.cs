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
    public partial class MaterialsForm : Form
    {
        private readonly IDbWorker _db;
        public MaterialsForm(IDbWorker db)
        {
            InitializeComponent();
            _db = db;
        }
        private void MaterialsForm_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            dgvMat.DataSource = _db.Materials;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            _db.SaveChanges();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
