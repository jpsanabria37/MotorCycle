using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Repository;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


namespace MotorcycleCompany.ContextFactory
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.Development.json")
                .Build();

            var connection = configuration.GetConnectionString("sqlConnectionMySql");
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));

            var builder = new DbContextOptionsBuilder<RepositoryContext>()
                .UseMySql(connection, serverVersion, b => b.MigrationsAssembly("MotorcycleCompany"));

            return new RepositoryContext(builder.Options);

        }
    }
}
