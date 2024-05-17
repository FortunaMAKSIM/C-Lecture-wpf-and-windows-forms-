using laba3.Service.Interface;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class CustomMaterialsForm : Form
    {
        private readonly IDbWorker _db;
        private readonly IServiceProvider _service;
        public CustomMaterialsForm(IDbWorker db, IServiceProvider service)
        {
            InitializeComponent();
            _db = db;
            _service = service;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var control in flpMaterials.Controls)
                {
                    if (control is MaterialView materialView)
                    {
                        var material = _db.Materials.FirstOrDefault(m => m.Id == materialView.MaterialId);
                        if (material != null)
                        {
                            // Обновляем только измененные материалы
                            if (material.Name != materialView.MaterialName || material.Id != materialView.MaterialId)
                            {
                                material.Id = materialView.MaterialId;
                                material.Name = materialView.MaterialName;
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

        private void CustomMaterialsForm_Load(object sender, EventArgs e)
        {
            LoadMaterials();
        }
        private void LoadMaterials()
        {
            int top = 0;
            foreach (var material in _db.Materials)
            {
                var materialView = new MaterialView();
                materialView.MaterialId = material.Id;
                materialView.MaterialName = material.Name;

                materialView.ProductsButtonClicked += MaterialView_ProductsButtonClicked;

                materialView.Top = top; 
                flpMaterials.Controls.Add(materialView); 

                top += materialView.Height + 5;
            }
        }

        private void MaterialView_ProductsButtonClicked(object sender, int materialId)
        {

            var selectedMaterial = _db.Materials.FirstOrDefault(m => m.Id == materialId);
            if (selectedMaterial != null)
            {
                CustomProductsForm customProductForm = _service.GetRequiredService<CustomProductsForm>();
                customProductForm.SetSelectedMaterial(selectedMaterial.Id);
                customProductForm.ShowDialog();
            }
        }
    }
}
