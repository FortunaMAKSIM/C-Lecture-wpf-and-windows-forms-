using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using laba4.Data;
using static laba4.Data.Entities;

namespace laba4.Serv
{
    public class DataService : IDataService
    {
        private readonly DataContext _dbContext;
        public DataService(DataContext dbContext)
        {
            _dbContext = dbContext;

            _dbContext.Materials.Load();
            _dbContext.Products.Load();
        }

        public IEnumerable<Material> Materials => _dbContext.Materials.ToList();
        public IEnumerable<Product> Products => _dbContext.Products.ToList();
        public void SaveChanges()
        {
            try
            {
                _dbContext.SaveChanges();
                MessageBox.Show("Успешно сохранено");
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    MessageBox.Show($"Ошибка сохранения: {ex.InnerException.Message}");
                }
                else
                {
                    MessageBox.Show($"Ошибка сохранения: {ex.Message}");
                }
            }
        }
    }
}
