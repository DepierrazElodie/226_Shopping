namespace Shopping
{
    public class Cart
    {
        #region private attributes
        private List<Article> _articles = new List<Article>();
        #endregion private attributes

        #region public methods

        public void Add(List<Article> articles)
        {
            _articles.AddRange(articles);
        }

        public List<Article> Remove(Boolean clearCart = false)
        {
                List<Article> articlesReadyToCheckout = new List<Article>();
                 articlesReadyToCheckout.Add(_articles.Last());
                _articles.Remove(_articles.Last());

            
            if (clearCart) 
            {         
                articlesReadyToCheckout.AddRange(_articles);
                _articles.Clear();
            }
            return articlesReadyToCheckout;

        }


        public List<Article> Articles
        {
            get
            {
               return _articles ;
            }
        }
        #endregion public methods
    }
}
