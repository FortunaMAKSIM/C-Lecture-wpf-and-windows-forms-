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
    public class MaterialStandart
    {
        private readonly IDataService _db;
        public ObservableCollection<Material> Materials { get; set; }

        public MaterialStandart(IDataService dataService)
        {
            _db = dataService;
            SaveCommand = new RelayComands(SaveChanges);
            Materials = new ObservableCollection<Material>(_db.Materials);
        }

        public ICommand SaveCommand { get; }

        private void SaveChanges(object parameter)
        {
            _db.SaveChanges();
        }
    }
}
