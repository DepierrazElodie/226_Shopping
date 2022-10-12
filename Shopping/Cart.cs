﻿namespace Shopping
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

<<<<<<< HEAD
=======
        public void Release()
        {
            throw new NotImplementedException();
        }
>>>>>>> c1c94a31ffabb762ee1ff40f8df36e678aabaa17

        public List<Article> Articles
        {
            get
            {
               return _articles ;
            }
        }

        public bool? IsReleased { get; set; }
        #endregion public methods
    }
}
