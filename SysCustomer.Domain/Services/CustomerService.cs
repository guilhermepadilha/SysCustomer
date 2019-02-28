using SysCustomer.Domain.Entities;
using SysCustomer.Domain.Interfaces;
using SysCustomer.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysCustomer.Domain.Services
{
    public class CustomerService : ServiceBase<Customer>, ICustomerService
    {
        public readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
            :base(customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IEnumerable<Customer> GetCustomersByClassification(int classificationId)
        {
            return GetAll().Where(c => c.ClassificationId == classificationId);
        }
    }
}
