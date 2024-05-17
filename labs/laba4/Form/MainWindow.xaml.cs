using laba4.Form;
using laba4.Forms;
using laba4.Serv;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace laba4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IServiceProvider _service;
        private readonly IDataService iDataService;
        public MainWindow(IServiceProvider service)
        {
            InitializeComponent();
            _service = service;
            iDataService = _service.GetRequiredService<IDataService>();
        }
        private void MaterialStandart_Btn(object sender, RoutedEventArgs e)
        {
            MaterialWindow materialsWindow = new(iDataService);
            materialsWindow.Show();
        }
        private void ProductStandart_Btn(object sender, RoutedEventArgs e)
        {
            ProductWindow productsWindow = new(iDataService);
            productsWindow.Show();
        }

        private void ProductCustom_Btn(object sender, RoutedEventArgs e)
        {
            ProductCustomWindow productsCustWindow = new(iDataService);
            productsCustWindow.Show();
        }
        private void MaterialCustom_Btn(object sender, RoutedEventArgs e)
        {
            MaterialCustomWindow MaterialsCustWindow = new(iDataService);
            MaterialsCustWindow.Show();
        }
    }
}