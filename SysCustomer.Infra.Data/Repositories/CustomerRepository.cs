using SysCustomer.Domain.Entities;
using SysCustomer.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysCustomer.Infra.Data.Repositories
{
    public class CustomerRepository : RepositoryBase<Customer>,  ICustomerRepository
    {
    }
}
