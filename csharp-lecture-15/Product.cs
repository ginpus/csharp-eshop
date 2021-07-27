using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lecture_15
{
    internal abstract class Product
    {
        //public Guid Id { get; set; };
        protected Type _productType;

        protected readonly int _id;
        protected int _price;
        protected int _quantity;
        // public Guid BasketId { get; set; };

        public abstract int SetPrice();

        public abstract int SetQuantity();

        public abstract Type SetType();

        public abstract int CheckMaxStock();

        public Product(int id, Type productType)
        {
            _id = id;
            _productType = productType;
            _quantity = SetQuantity(); //randomly generated value
        }

        public void ChangePrice(int newPrice)
        {
            _price = newPrice;
        }

        public override string ToString()
        {
            return string.Format("ID = {0}, Type = {1}, Price = {2}, Quantity = {3}",
                this._id,
                this._productType,
                this._price,
                this._quantity); ;
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
            return 0 != _quantity; // return true, if quantity is not zero
            /*if (0 == _quantity)
            {
                return false;
            }
            return true;*/
        }

        public int GetPrice()
        {
            return _price;
        }

        public int GetStock()
        {
            return _quantity;
        }

        public int GetId()
        {
            return (int)_productType;
        }

        public Type GetTyp()
        {
            return _productType;
        }

        public void SetNewQuantity(int quantity)
        {
            _quantity = quantity;
        }
    }
}