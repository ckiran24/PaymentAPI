using PaymentAPI.Services.Interfaces;

namespace PaymentAPI.Services.Implementations
{
    public class CardPaymentService : IPaymentService
    {
        public string Pay(decimal amount)
        {
            return $"Payment of ₹{amount} processed using Card";
        }
    }
}
