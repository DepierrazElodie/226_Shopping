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

        public List<Article> Remove(Boolean empty = false)
        {
            List<Article> machin = new List<Article>(); machin = _articles;
            
            return machin;
           
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
