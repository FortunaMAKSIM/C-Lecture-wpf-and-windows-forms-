using Microsoft.Extensions.DependencyInjection;

namespace laba3
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public MainForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void prodBtn_Click(object sender, EventArgs e)
        {
            ProductsForm products = _serviceProvider.GetRequiredService<ProductsForm>();
            products.Show();
        }

        private void matBtn_Click(object sender, EventArgs e)
        {
            MaterialsForm materials = _serviceProvider.GetRequiredService<MaterialsForm>();
            materials.Show();
        }

        private void CustProdBtn_Click(object sender, EventArgs e)
        {
            CustomProductsForm productsCustom = _serviceProvider.GetRequiredService<CustomProductsForm>();
            productsCustom.Show();
        }

        private void CustMatBtn_Click(object sender, EventArgs e)
        {
            CustomMaterialsForm materialsCustom = _serviceProvider.GetRequiredService<CustomMaterialsForm>();
            materialsCustom.Show();
        }
    }
}
