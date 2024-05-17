using laba3.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3.Service.Interface
{
    public interface IDbWorker
    {
        public IEnumerable<Material> Materials { get; }
        public IEnumerable<Product> Products { get; }

        public void SaveChanges();
    }
}
