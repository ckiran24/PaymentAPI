using Microsoft.AspNetCore.Mvc;
using PaymentAPI.Models;
using PaymentAPI.Services;

namespace PaymentAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly PaymentServiceResolver _resolver;

        public PaymentController(PaymentServiceResolver resolver)
        {
            _resolver = resolver;
        }

        [HttpPost]
        public IActionResult ProcessPayment([FromBody] PaymentRequest request)
        {
            if (request.Amount<=0)
            {
                return BadRequest("Amount must be greater than zero");
            }

            var service = _resolver.Resolve(request.Type);
            var result = service.ProcessPayment(request.Amount);
            return Ok(result);
        }
    }
}
