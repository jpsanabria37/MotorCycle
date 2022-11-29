using Contracts;
using LoggerService;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service;
using Service.Contracts;

namespace MotorcycleCompany.Extensions
{
    public static class ServiceExtensions
    {

        /* Methods Extensors: 1) Static 2) this */

        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                );
            });

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {
                // options.AutomaticAuthentication = true;

            });

        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddSingleton<ILoggerManager, LoggerManager>();

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();


        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("sqlConnectionMySql");
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));

            services.AddDbContext<RepositoryContext>(opts => opts.UseMySql(connection, serverVersion, b => b.MigrationsAssembly("MotorcycleCompany")));
        }


    }
}
