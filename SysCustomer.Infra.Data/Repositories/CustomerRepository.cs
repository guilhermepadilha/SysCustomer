using SysCustomer.Domain.Entities;
using SysCustomer.Domain.Interfaces;
using SysCustomer.Infra.Data.Context;   

namespace SysCustomer.Infra.Data.Repositories
{
    public class CustomerRepository : RepositoryBase<Customer>,  ICustomerRepository
    {
        public CustomerRepository(SysCustomerContext context)
        {
            
        }
    }
}
