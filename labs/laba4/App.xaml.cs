using laba4.Data;
using laba4.Form;
using laba4.Forms;
using laba4.Serv;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;
using System.Data;
using System.Windows;

namespace laba4
{
    public partial class App : Application
    {
        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<MainWindow>();
            services.AddSingleton<MaterialWindow>();
            services.AddSingleton<ProductWindow>();
            services.AddSingleton<ProductCustomWindow>();
            services.AddSingleton<MaterialCustomWindow>();

            services.AddScoped<IDataService, DataService>();

            services.AddDbContext<DataContext>(options =>
                options.UseSqlite("Data Source=helloapp.db"));
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var mainWindow = serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }
    }

}
