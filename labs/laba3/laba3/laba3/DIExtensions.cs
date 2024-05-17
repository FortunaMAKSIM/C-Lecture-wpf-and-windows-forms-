using laba3.Database;
using laba3.Service.Implementations;
using laba3.Service.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    internal static class DIExtensions
    {
        public static void InitServices(this ServiceCollection services)
        {
            services.AddTransient<MainForm>();
            services.AddTransient<MaterialsForm>();
            services.AddTransient<ProductsForm>();
            services.AddScoped<IDbWorker, DbWorker>();
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite("Data source=./app.db")
            );
        }
    }
}
