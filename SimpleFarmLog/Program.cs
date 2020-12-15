using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using SimpleFarmLog.EF;
using SimpleFarmLog.Entities;
using SimpleFarmLog.Repositories;
using SimpleFarmLog.Services;
using System;
using System.IO;
using System.Threading.Tasks;

namespace SimpleFarmLog
{
    class Program
    {       
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();

            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Build())
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .CreateLogger();

            Log.Logger.Information("Application Starting");

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, service) =>
                {
                    service.AddDbContextPool<AppDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
                    //Register repo
                    service.AddTransient<IGenericRepository<Boar>, GenericRepository<Boar>>();
                    service.AddTransient<IGenericRepository<BoarHerd>, GenericRepository<BoarHerd>>();
                    service.AddTransient<IGenericRepository<Fodder>, GenericRepository<Fodder>>();
                    service.AddTransient<IGenericRepository<Ingredient>, GenericRepository<Ingredient>>();
                    service.AddTransient<IGenericRepository<Medicine>, GenericRepository<Medicine>>();
                    service.AddTransient<IGenericRepository<InjectLog>, GenericRepository<InjectLog>>();
                    service.AddTransient<IGenericRepository<SeedLog>, GenericRepository<SeedLog>>();
                    service.AddTransient<IGenericRepository<PurchaseLog>, GenericRepository<PurchaseLog>>();
                    service.AddTransient<IGenericRepository<MixLog>, GenericRepository<MixLog>>();
                    service.AddTransient<IUnitOfWork, UnitOfWork>();

                    service.AddTransient<IBoarService, BoarService>();
                    service.AddTransient<IHerdService, HerdService>();

                    //service.AddTransient<ISimpleFarmLog, SimpleFarmLog>();
                })
                .UseSerilog()
                .Build();

            var service = ActivatorUtilities.CreateInstance<SimpleFarmLog>(host.Services);
            service.Run();
        }

        static void BuildConfig(IConfigurationBuilder builder)
        {
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();            
        }
    }
}
