using Shopping;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        Cart _cart = new Cart();
       


        
        public void Main(string[] args)
        {
          foreach(Article article in _cart.Articles)
            {
                _cart.Remove( article);
            }
        }
    }
}