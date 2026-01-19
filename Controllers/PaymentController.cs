using Microsoft.AspNetCore.Mvc;
using PaymentAPI.Services;
//use abstraction
namespace PaymentAPI.Controllers
{
    [ApiController]
    [Route("api/payment")]
    public class PaymentController : ControllerBase
    {
        private readonly PaymentServiceResolver _resolver;

        public PaymentController(PaymentServiceResolver resolver)
        {
            _resolver = resolver;
        }

        [HttpPost]
        public IActionResult Pay(string type, decimal amount)
        {
            var service = _resolver.Resolve(type);
            var result = service.Pay(amount);
            return Ok(result);
        }
    }
}
