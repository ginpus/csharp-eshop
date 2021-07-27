using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lecture_15
{
    internal class Basket
    {
        protected List<Product> _basket;

        public Basket() // at creation of Basket, an empty Product type list gets created
        {
            _basket = new List<Product>();
        }

        public void AddToBasket(Product product)
        {
            _basket.Add(product);
        }

        public void ShowBasketContents()
        {
            foreach (Product product in _basket)
            {
                {
                    Console.WriteLine(product.ToString());
                }
            }
        }
    }
}