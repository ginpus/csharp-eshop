using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lecture_15
{
    internal class User
    {
        protected int _balance;
        private readonly Basket _basket;

        protected Random _rd;

        public User()
        {
            _basket = new Basket(); // at creation of user, a Basket object gets created (which is in fact an empty list of Products)
        }

        public int ShowBalance()
        {
            Console.WriteLine($"Current balance: {_balance}");
            return _balance;
        }

        public int SetRandomBalance()
        {
            Random _rd = new Random();
            _balance = _rd.Next(20, 200);
            return _balance;
        }

        public int TopUpBalance(int topUpSum)
        {
            _balance += topUpSum;
            Console.WriteLine($"Balanced has been filled by {topUpSum}.");
            ShowBalance();
            return _balance;
        }

        public int Buy(int buySum)
        {
            _balance -= buySum;
            return _balance;
        }
    }
}