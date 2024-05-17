using laba3.Database.Entities;
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
    public partial class CustomProductsForm : Form
    {
        private readonly IDbWorker _db;
        private int _selectedMaterialId;
        public CustomProductsForm(IDbWorker db)
        {
            InitializeComponent();
            _db = db;
        }

        private void CustomProductsForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void LoadProducts()
        {
            IEnumerable<Product> filteredProducts;
            int top = 0;
            if (_selectedMaterialId == 0)
            {
                filteredProducts = _db.Products;
            }
            else
            {
                filteredProducts = _db.Products.Where(p => p.MaterialId == _selectedMaterialId);
            }

            foreach (var product in filteredProducts)
            {
                var productView = new ProductView();
                productView.ProductId = product.Id;
                productView.ProductName = product.Name;
                productView.ProductPrice = (int)product.Price;

                productView.LoadMaterials(_db.Materials.Select(m => m.Name));
                productView.SelectedMaterial = _db.Materials.FirstOrDefault(m => m.Id == product.MaterialId)?.Name;

                productView.Top = top;
                flpProducts.Controls.Add(productView);

                top += productView.Height + 5;
            }
        }
        public void SetSelectedMaterial(int materialId)
        {
            _selectedMaterialId = materialId;
            LoadProducts();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var control in flpProducts.Controls)
                {
                    if (control is ProductView productView)
                    {
                        var product = _db.Products.FirstOrDefault(p => p.Id == productView.ProductId);
                        if (product != null)
                        {

                            if (product.Id != productView.ProductId ||
                                product.Name != productView.ProductName ||
                                product.Price != productView.ProductPrice ||
                                product.Material.Name != productView.SelectedMaterial)
                            {
                                product.Id = productView.ProductId;
                                product.Name = productView.ProductName;
                                product.Price = productView.ProductPrice;
                                product.Material.Name = productView.SelectedMaterial;
                            }
                        }
                    }
                }

                _db.SaveChanges();

                MessageBox.Show("Изменения успешно сохранены.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
