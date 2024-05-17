using laba4.Form;
using laba4.Serv;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static laba4.Data.Entities;

namespace laba4.DataForm
{
    public class MaterialCustom : DataFormBase
    {
        private readonly IDataService _db;
        public ObservableCollection<Material> Materials { get; }

        public MaterialCustom(IDataService dataService)
        {
            _db = dataService;

            SaveCommand = new RelayComands(SaveChanges);
            OpenProductsCustomRequested = new RelayComands(OpenProductsCustom);
            Materials = new ObservableCollection<Material>(_db.Materials);
        }

        public ICommand SaveCommand { get; }
        public ICommand OpenProductsCustomRequested { get; }

        private void SaveChanges(object parameter)
        {
            _db.SaveChanges();
        }

        private void OpenProductsCustom(object parameter)
        {
            if (parameter is int materialId)
            {
                ProductCustomWindow productsCustom = new(_db, materialId);
                productsCustom.Show();
            }
        }
    }
}
