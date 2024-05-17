using laba4.DataForm;
using laba4.Serv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace laba4.Form
{
    /// <summary>
    /// Логика взаимодействия для MaterialCustomWindow.xaml
    /// </summary>
    public partial class MaterialCustomWindow : Window
    {
        public MaterialCustomWindow(IDataService dataService)
        {
            InitializeComponent();
            DataContext = new MaterialCustom(dataService);
        }
    }
}
