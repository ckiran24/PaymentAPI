namespace PaymentAPI.Models
{
    public class PaymentRequest
    {
        public string Type { get; set; } = string.Empty;
        public decimal Amount { get; set; }
    }
}
