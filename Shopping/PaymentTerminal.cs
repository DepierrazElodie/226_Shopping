namespace Shopping
{
    public class PaymentTerminal
    {
        #region private attributes
        private Checkout _checkout = new Checkout();
        #endregion private attributes

        #region public methods
        public PaymentTerminal(Checkout checkout)
        {
            _checkout = checkout;
        }

        public object? CreditCard { get; set; }

        public void Cash(float balance)
        {
            
            Console.WriteLine();
            _checkout._balance = 0;

        }

        public void InsertCard(CreditCard creditCard)
        {
            
            
            Console.WriteLine(creditCard);
            CreditCard = true;
            
        }

        public void RemoveCard()
        {
            
            CreditCard = null;
        }
        #endregion public methods
    }
}
