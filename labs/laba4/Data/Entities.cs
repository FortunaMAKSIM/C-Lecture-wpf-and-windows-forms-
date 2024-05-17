using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace laba4.Data
{
    public class Entities
    {
        public class Product
        {
            public int Id { get; set; }
            public string Title { get; set; } = string.Empty;
            public int Price { get; set; } = 0;
            public int MaterialId { get; set; } = 1;
            public virtual Material Material { get; set; } = null!;
        }
        public class Material
        {
            public int Id { get; set; }
            public string Title { get; set; } = string.Empty;
            public virtual IEnumerable<Product> Products { get; set; }
        }
    }
}
