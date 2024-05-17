using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3.Database.Entities
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
