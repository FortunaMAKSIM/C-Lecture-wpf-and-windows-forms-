using laba4.DataForm;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace laba4.Control
{
    /// <summary>
    /// Логика взаимодействия для MaterialContr.xaml
    /// </summary>
    public partial class MaterialContr : UserControl
    {
        public MaterialContr()
        {
            InitializeComponent();
        }
        public static readonly DependencyProperty IdProperty =
            DependencyProperty.Register("Id", typeof(int), typeof(MaterialContr), new PropertyMetadata(0));
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(MaterialContr), new PropertyMetadata(string.Empty));
        public static readonly DependencyProperty DataContextProperty =
            DependencyProperty.Register("DataContext", typeof(MaterialCustom), typeof(MaterialContr), new PropertyMetadata(null));

        public int Id
        {
            get { return (int)GetValue(IdProperty); }
            set { SetValue(IdProperty, value); }
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public MaterialCustom DataContext
        {
            get { return (MaterialCustom)GetValue(DataContextProperty); }
            set { SetValue(DataContextProperty, value); }
        }
    }
}
