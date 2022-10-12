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
            //doit vider l'argent de la balance
            throw new NotImplementedException();
        }

        public void InsertCard(CreditCard creditCard)
        {
            Console.WriteLine("insert card");
            
        }

        public void RemoveCard()
        {
            //step 8 même chose qu'au 6 mais inversé
            throw new NotImplementedException();
        }
        #endregion public methods
    }
}
