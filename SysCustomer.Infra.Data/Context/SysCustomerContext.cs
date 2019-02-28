using Microsoft.EntityFrameworkCore;
using SysCustomer.Domain.Entities;

namespace SysCustomer.Infra.Data.Context
{
    public class SysCustomerContext : DbContext
    {

        public SysCustomerContext()
            : base(new DbContextOptions<SysCustomerContext>())
    {
      //.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"])
    }

    public DbSet<Customer> Customers { get; set; }
    }
}
