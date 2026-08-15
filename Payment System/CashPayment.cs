namespace Payment_System
{
    public class CashPayment : PaymentMethod
    {
        public CashPayment(decimal amount) : base(amount)
        {
        }

        public override void Pay()
        {
            Console.WriteLine($"Paid ${Amount} in cash.");
        }
    }
}
