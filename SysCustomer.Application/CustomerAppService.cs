using SysCustomer.Application.Interface;
using SysCustomer.Domain.Entities;
using SysCustomer.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace SysCustomer.Application
{
    public class CustomerAppService : AppServiceBase<Customer>, ICustomerAppService
    {
        private readonly ICustomerService _customerService;

        public CustomerAppService(ICustomerService customerService)
            :base(customerService)
        {
            _customerService = customerService;
        }

        public IEnumerable<Customer> GetCustomersByClassification(int classificationId)
        {
           return _customerService.GetCustomersByClassification(classificationId);
        }
    }
}
