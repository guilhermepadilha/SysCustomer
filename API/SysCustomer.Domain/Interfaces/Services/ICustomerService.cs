using SysCustomer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysCustomer.Domain.Interfaces.Services
{
    public interface ICustomerService : IServiceBase<Customer>
    {
        IEnumerable<Customer> GetCustomersByClassification(int classificationId);
    }
}
