using System;
using System.Collections.Generic;

namespace csharp_lecture_15
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var list = new Product();
            var books = new Book();

            books.SetPrice();
            books.SetQuantity();
            books.SetType();
            books.GetList(books);

            list.AddToList(books);

            list.PrintList(list);

            /* var desire = "y";

             while (desire == "y")
             {
                 Console.Write("\n1 - List all items in the shop;\n2 - Buy item;\n3 - Add item;\n7 - Exit shop;\n\nPick your choice: ");
                 var input = Console.ReadLine();
                 var choice = Convert.ToInt32(input);

                 if (choice == 1)
                 {
                     Console.WriteLine("Here is the list of all items");
                 }
                 else if (choice == 2)
                 {
                     Console.WriteLine("You are about to buy something. Pick what you want to buy");
                     Console.Write("\n1 - Cups;\n2 - Books;\n3 - Candies;\n7 - Back;\n\nPick your choice: ");
                     var buy = Console.ReadLine();
                     var whatToBuy = Convert.ToInt32(buy);
                     if (whatToBuy == 1)
                     {
                         Console.WriteLine("You are about to buy cups. Select desired amount:");
                         var numberOfCups = Console.ReadLine();
                         var cups = Convert.ToInt32(numberOfCups);
                         Console.WriteLine($"Great! {cups} added to your basket.");
                     }
                     else if (whatToBuy == 2)
                     {
                         Console.WriteLine("You are about to buy books");
                     }
                     else if (whatToBuy == 3)
                     {
                         Console.WriteLine("You are about to buy candies");
                     }
                     else
                     {
                         Console.WriteLine("Going back to main menu");
                         break;
                     }
                 }
                 else if (choice == 3)
                 {
                     Console.WriteLine("You are about to buy 30 cups");
                 }
                 else if (choice == 7)
                 {
                     Console.WriteLine("Exiting shop");
                     desire = "n";
                 }
                 else
                 {
                     Console.WriteLine("Sorry, no such selection. Try again");
                 }
             }*/
        }
    }
}