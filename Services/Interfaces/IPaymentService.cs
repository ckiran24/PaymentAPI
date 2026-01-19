namespace PaymentAPI.Services.Interfaces
{
    public interface IPaymentService
    {
        string PaymentType { get; }   // "card", "upi
        string ProcessPayment(decimal amount);
    }
}
