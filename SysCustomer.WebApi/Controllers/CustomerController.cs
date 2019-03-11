

using Microsoft.AspNetCore.Mvc;
using SysCustomer.Application.Interface;

namespace SysCustomer.WebApi.Controllers
{
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
        public IActionResult GetAllCustomers()
        {
            try
            {
                return Ok(_customerAppService.GetAll());
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
