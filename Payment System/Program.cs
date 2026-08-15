namespace Payment_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentMethod[] payments = new PaymentMethod[]
            {
                new CreditCardPayment(1500),
                new CashPayment(300)
            };

            foreach (var payment in payments)
            {
                payment.Pay();
                payment.PrintReceipt();

                if (payment is IRefundable refundablePayment)
                {
                    refundablePayment.Refund();
                }

                Console.WriteLine("--------------------------------------");
            }
        }
    }
 }