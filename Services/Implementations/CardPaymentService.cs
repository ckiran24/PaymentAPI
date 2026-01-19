using PaymentAPI.Services.Interfaces;

namespace PaymentAPI.Services.Implementations
{
    public class CardPaymentService : IPaymentService
    {
        public string PaymentType => "card";

        public string ProcessPayment(decimal amount)
        {
            return $"Card payment of ₹{amount} processed";
        }
    }
}
