using Microsoft.EntityFrameworkCore;
using SysCustomer.Domain.Entities;

namespace SysCustomer.Infra.Data.Context
{
    public class SysCustomerContext : DbContext
    {

        public SysCustomerContext(DbContextOptions<SysCustomerContext> options)
            : base(options){
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
