using Microsoft.Extensions.DependencyInjection;
using System;

namespace laba3
{
    internal static class Program
    {
        private static IServiceProvider _serviceProvider = null!;
        
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            services.InitServices();
            _serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(_serviceProvider.GetRequiredService<MainForm>());
        }
    }
}