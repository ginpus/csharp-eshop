using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace csharp_lecture_15
{
    internal class Shop
    {
        protected List<Product> _productList;

        public Shop()
        {
            _productList = new List<Product> { };
        }

        public List<Product> AddToList(Product product)
        {
            _productList.Add(product);
            return _productList;
        }

        public void PrintAllProducts()
        {
            foreach (Product product in _productList)
            {
                if (product.CheckExistance())  // eliminuoja tuos irasus, kuriu kiekis lygus nuliui
                {
                    Console.WriteLine(product.ToString());
                }
            }
        }

        public void PrintAllTypes()
        {
            var count = 0;
            foreach (var name in Enum.GetNames(typeof(Type)))
            {
                Console.WriteLine($"{++count}: {name}");
            }
        }

        /*        public Product CheckProduct(Type type)
                {
                    foreach (Product product in _productList)
                    {
                        if (type == Type.);
                    }
                }*/
    }
}