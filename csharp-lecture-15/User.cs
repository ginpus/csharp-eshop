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
        protected Random _rd;

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