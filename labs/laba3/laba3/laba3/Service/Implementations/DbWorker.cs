using laba3.Database;
using laba3.Database.Entities;
using laba3.Service.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3.Service.Implementations
{
    internal class DbWorker : IDbWorker
    {
        private readonly AppDbContext _dbContext;
        private readonly List<Product> _products;
        private readonly List<Material> _materials;

        public DbWorker(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
            _dbContext.Materials.Load();
            _dbContext.Products.Load();
        }

        public IEnumerable<Product> Products => _dbContext.Products.ToList();
        public IEnumerable<Material> Materials => _dbContext.Materials.ToList();

        public void SaveChanges() => _dbContext.SaveChanges();
    }
}
