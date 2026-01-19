using PaymentAPI.Services.Interfaces;

namespace PaymentAPI.Services.Implementations
{
    public class UpiPaymentService : IPaymentService
    {
        public string PaymentType => "upi";

        public string ProcessPayment(decimal amount)
        {
            return $"UPI payment of ₹{amount} processed";
        }
    }
}
