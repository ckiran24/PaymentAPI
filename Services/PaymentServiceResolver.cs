using PaymentAPI.Services.Interfaces;
using PaymentAPI.Services.Implementations;

namespace PaymentAPI.Services
{
    // Resolves payment service based on payment type
    public class PaymentServiceResolver
    {
        public IPaymentService Resolve(string paymentType)
        {
            return paymentType.ToLower() switch
            {
                "card" => new CardPaymentService(),
                "upi" => new UpiPaymentService(),
                _ => throw new ArgumentException("Invalid payment type")
            };
        }
    }
}
