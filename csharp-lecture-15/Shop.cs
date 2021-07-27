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

        protected readonly Book _book;
        protected readonly Cup _cup;
        protected readonly Candy _candy;

        public Shop()
        {
            _productList = new List<Product> // creation of product type objects
            {
                new Book((int)Type.Book, Type.Book), // id and name is discretional values defined by enum
                new Cup((int)Type.Cup, Type.Cup),
                new Candy((int)Type.Candy, Type.Candy)
            };
        }

        public void Fill(int type, int quantity)
        {
            var product = GetProductById(type);
            product.SetNewQuantity(product.GetStock() + quantity);
            Console.WriteLine($"{quantity} of {product.GetTyp()} has been added. Now we have {product.GetStock()}.");
        }

        public void Sell(int type, int quantity)
        {
            var product = GetProductById(type);
            product.SetNewQuantity(product.GetStock() - quantity); //we take the current stock and decrease it by inserted value
            Console.WriteLine($"Currently we have {product.GetStock()} {product.GetTyp()} left.");
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

        public Product GetProductById(int id) // method to return product object
        {
            foreach (Product product in _productList)
            {
                if (product.GetId() == id)
                {
                    return product;
                }
            }
            return null;
        }

        // ability to add any other product into the list
        public List<Product> AddToList(Product product)
        {
            _productList.Add(product);
            return _productList;
        }

        public void PrintAllTypes()
        {
            var count = 0;
            foreach (var name in Enum.GetNames(typeof(Type)))
            {
                Console.WriteLine($"{++count}: {name}");
            }
        }

        public void PrintAllSelections()
        {
            var count = 0;
            foreach (var name in Enum.GetNames(typeof(Selection)))
            {
                Console.WriteLine($"{++count}: {name}");
            }
        }
    }
}