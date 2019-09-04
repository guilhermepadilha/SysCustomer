using SysCustomer.Domain.Entities;
using System.Collections.Generic;

namespace SysCustomer.Application.Interface
{
    public interface ICustomerAppService : IAppServiceBase<Customer>
    {
        IEnumerable<Customer> GetCustomersByClassification(int classificationId);
    }

}



