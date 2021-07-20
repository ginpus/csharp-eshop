using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lecture_15
{
    internal class Book : Product
    {
        protected Random _rd;

        public int SetPrice()
        {
            Random _rd = new Random();
            _price = _rd.Next(12, 35);
            return _price;
        }

        public int SetQuantity()
        {
            Random _rd = new Random();
            _quantity = _rd.Next(1, 120);
            return _quantity;
        }

        public Type SetType()
        {
            _productType = Type.Book;
            return _productType;
        }
    }
}