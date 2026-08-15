namespace Payment_System
{
    public class CreditCardPayment : PaymentMethod, IRefundable
    {
        public CreditCardPayment(decimal amount) : base(amount) { }

        public override void Pay()
        {
            Console.WriteLine($"Paid ${Amount} with a credit card.");
        }

        public void Refund()
        {
            Console.WriteLine($"Refunded ${Amount} to the credit card.");
        }
    }
}
