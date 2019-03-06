using Microsoft.EntityFrameworkCore;
using SysCustomer.Domain.Entities;

namespace SysCustomer.Infra.Data.Context
{
    public class SysCustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlServer(@"Data Source = (localdb)\\mssqllocaldb; Initial Catalog = DataBase; Integrated Security = True");

    //    //if (!optionsBuilder.IsConfigured)
    //    //{
    //    //    IConfigurationRoot configuration = new ConfigurationBuilder()
    //    //       .SetBasePath(Directory.GetCurrentDirectory())
    //    //       .AddJsonFile("appsettings.json")
    //    //       .Build();
    //    //    var connectionString = configuration.GetConnectionString("DbCoreConnectionString");
    //    //    optionsBuilder.UseSqlServer(connectionString);
    //    //}
    //}
}
