using Laba2;
using Microsoft.Extensions.DependencyInjection;
using WinFormsApp.Database;
using WinFormsApp.Services.Implementations;
using WinFormsApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp;

internal static class DIExtensions
{
    public static void InitServices(this ServiceCollection services)
    {
        services.AddTransient<MainForm>();
        services.AddTransient<LoginDialog>();
        services.AddTransient<RegisterDialog>();

        services.AddScoped<IDbWorker, FakeDbWorker>();

        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite("Data source=./app.db")
        );
    }
}