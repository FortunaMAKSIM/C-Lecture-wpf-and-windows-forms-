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
    public class ProductCustom : DataFormBase
    {
        private readonly IDataService _db;
        public ObservableCollection<Product> Products { get; }
        public ObservableCollection<Material> Materials { get; }

        public ProductCustom(IDataService dataService, int materialId)
        {
            _db = dataService;

            SaveCommand = new RelayComands(SaveChanges);

            if (materialId > 0)
            {
                Products = new ObservableCollection<Product>(_db.Products.Where(p => p.MaterialId == materialId));
            }
            else
            {
                Products = new ObservableCollection<Product>(_db.Products);
            }
            Materials = new ObservableCollection<Material>(_db.Materials);
        }

        public ICommand SaveCommand { get; }

        private void SaveChanges(object parameter)
        {
            _db.SaveChanges();
        }
    }
}
