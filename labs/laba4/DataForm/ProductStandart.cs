using laba4.Serv;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static laba4.Data.Entities;
using System.Windows.Input;

namespace laba4.DataForm
{
    internal class ProductStandart : DataFormBase
    {
        private readonly IDataService _db;
        public ObservableCollection<Product> Products { get; }

        public ProductStandart(IDataService dataService)
        {
            _db = dataService;
            SaveCommand = new RelayComands(SaveChanges);
            Products = new ObservableCollection<Product>(_db.Products);
        }

        public ICommand SaveCommand { get; }

        private void SaveChanges(object parameter)
        {
            _db.SaveChanges();
        }
    }
}
