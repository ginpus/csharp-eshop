using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lecture_15
{
    internal abstract class Product
    {
        protected Type _productType;
        protected int _price;
        protected int _quantity;

        public abstract int SetPrice();

        public abstract int SetQuantity();

        public abstract Type SetType();

        public abstract int CheckMaxStock();

        public override string ToString()
        {
            return string.Format("Type = {0}, Price = {1}, Quantity = {2}",
                this._productType,
                this._price,
                this._quantity);
        }

        public void CheckInventory(Type type)
        {
            if (type == _productType)
            {
                Console.WriteLine($"Currently we have {_quantity} of {_productType}");
            }
        }

        public bool CheckSufficiency(int buyQnt)
        {
            if (buyQnt <= _quantity)
            {
                return true;
            }
            return false;
        }

        public bool CheckExistance()
        {
            return 0 != _quantity;
            /*if (0 == _quantity)
            {
                return false;
            }
            return true;*/
        }

        public void Sell(Type type, int quantity)
        {
            if (type == _productType)
            {
                _quantity -= quantity;
                Console.WriteLine($"Currently we have {_quantity} {_productType} left.");
            }
        }

        public void Fill(Type type, int quantity)
        {
            if (type == _productType)
            {
                _quantity += quantity;
                Console.WriteLine($"{quantity} of {_productType} has been added. Now we have {_quantity}.");
            }
        }

        public int GetPrice()
        {
            return _price;
        }

        public int GetStock()
        {
            return _quantity;
        }
    }
}