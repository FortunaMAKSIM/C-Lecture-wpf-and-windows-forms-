using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static laba4.Data.Entities;

namespace laba4.Serv
{
    public interface IDataService
    {
        public IEnumerable<Material> Materials { get; }
        public IEnumerable<Product> Products { get; }
        public void SaveChanges();
    }
}
