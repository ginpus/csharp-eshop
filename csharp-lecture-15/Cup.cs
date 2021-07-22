using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lecture_15
{
    internal class Cup : Product
    {
        protected Random _rd;
        protected readonly int _maxStock = 60;

        public override int CheckMaxStock()
        {
            return _maxStock;
        }

        public override int SetPrice()
        {
            Random _rd = new Random();
            _price = _rd.Next(5, 15);
            return _price;
        }

        public override int SetQuantity()
        {
            Random _rd = new Random();
            _quantity = _rd.Next(1, _maxStock);
            return _quantity;
        }

        public override Type SetType()
        {
            _productType = Type.Cup;
            return _productType;
        }
    }
}