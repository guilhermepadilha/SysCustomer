

using Microsoft.AspNetCore.Mvc;
using SysCustomer.Application.Interface;
using SysCustomer.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;

namespace SysCustomer.WebApi.Controllers
{
    [Authorize]
    [Route("api/customer")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerAppService _customerAppService;

        public CustomerController(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }

        [HttpGet]
        [Route("{customerId:int}")]
        public IActionResult GetCustomer(int customerId)
        {
            try
            {
                return Ok(_customerAppService.GetById(customerId));
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetAllCustomers()
        {
            try
            {
                var customers = _customerAppService.GetAll().ToList();
                return customers;
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
