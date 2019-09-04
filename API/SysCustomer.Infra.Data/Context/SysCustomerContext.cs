

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SysCustomer.Domain.Entities;

namespace SysCustomer.Infra.Data.Context
{
  public class SysCustomerContext : IdentityDbContext
    {
    public DbSet<Customer> Customer { get; set; }

        public SysCustomerContext()
        {   

        }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
            //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\\mssqllocaldb;AttachDbFilename=C:\Users\Guilherme\source\repos\SysCustomer\SysCustomer.WebApi\App_Data\DataBase.mdf;Database=SysCustomerDB;Initial Catalog=SysCustomerDB; Integrated Security=True");
            optionsBuilder.UseSqlServer(@"Data Source = (localdb)\mssqllocaldb; Initial Catalog = SysCustomerDB; Integrated Security = True");
    }

  }


}
