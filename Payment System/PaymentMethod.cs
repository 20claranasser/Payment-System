namespace Payment_System
{
    public abstract class  PaymentMethod
    {
        private decimal _amount;

        public decimal Amount { get { return _amount; } set { _amount = value; } }

        public PaymentMethod(decimal amount)
        {
            _amount = amount;
        }

        public void PrintReceipt()
        {
            Console.WriteLine($"Receipt: {this.GetType().Name} for the amount of ${Amount}");
        }

        public abstract void Pay();
    }
}
