using PaymentAPI.Services.Interfaces;

namespace PaymentAPI.Services.Implementations
{
    public class UpiPaymentService : IPaymentService
    {
        public string Pay(decimal amount)
        {
            return $"Payment of ₹{amount} processed using UPI";
        }
    }
}
