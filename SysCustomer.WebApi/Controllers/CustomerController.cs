

using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace SysCustomer.WebApi.Controllers
{
    [Route("api/syscustomer")]
    public class CustomerController : Controller
    {
        [HttpGet]
        [Route("customer/{customerId:int}")]
        public HttpResponseMessage GetCustomer (int customerId)
        {
            try
            {
                var _gamePointRepository = new CustomerRepository();


                //return Request.CreateResponse(HttpStatusCode.OK, _gamePointRepository.GetAllPlayers(gameId));

            }
            catch (System.Exception ex)
            {
                //return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
