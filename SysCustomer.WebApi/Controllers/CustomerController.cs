

using Microsoft.AspNetCore.Mvc;
using SysCustomer.Infra.Data.Repositories;
using System.Net;
using System.Net.Http;

namespace SysCustomer.WebApi.Controllers
{
  [Route("api/syscustomer")]
  public class CustomerController : ControllerBase
  {

    [HttpGet]
    [Route("customer/{customerId:int}")]
    public IActionResult GetCustomer(int customerId)
    {
      try
      {
        var _customerRepository = new CustomerRepository();


        return Ok(_customerRepository.GetById(customerId));
          

      }
      catch (System.Exception ex)
      {
        return BadRequest(ex);
      }
    }
  }
}
