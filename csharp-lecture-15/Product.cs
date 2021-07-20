using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lecture_15
{
    internal class Product
    {
        protected List<Product> _productList;
        protected Type _productType;

        protected int _price;
        protected int _quantity;

        /*        public abstract int SetPrice();

                public abstract int SetQuantity();

                public abstract Type SetType();*/

        public Product()
        {
            _productList = new List<Product> { };
        }

        public List<Product> AddToList(Product product)
        {
            _productList.Add(product);
            return _productList;
        }

        public void PrintList(List<Product> list)
        {
            foreach (var product in list)
            {
                Console.WriteLine($"Type: {_productType}; Price: {_price}; Quantity: {_quantity}");
            }
        }

        public void GetList(Product product)
        {
            Console.WriteLine($"{product} type is {_productType}. Price is: {_price} and quantity: {_quantity}");
        }
    }

    internal enum Type
    {
        Book,
        Cup,
        Candy
    }
}