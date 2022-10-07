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
            throw new NotImplementedException();
        }

<<<<<<< HEAD
        public void Remove(List<Article>? articles = null)
=======
        public List<Article> Remove(Boolean empty = false)
>>>>>>> 07ac386300b29db75e3a32b32f2523d5fd50ed0f
        {
            //Articles.Remove(articles);
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
