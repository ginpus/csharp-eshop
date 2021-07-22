using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace csharp_lecture_15
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // creation of a Product type object list
            var shop = new Shop();
            // creation of objects (Products) of each type
            var books = new Book();
            var cups = new Cup();
            var candies = new Candy();
            //creation of user
            var user = new User();

            //setting properties for each Product
            books.SetPrice();
            books.SetQuantity();
            books.SetType();

            cups.SetPrice();
            cups.SetQuantity();
            cups.SetType();

            candies.SetPrice();
            candies.SetQuantity();
            candies.SetType();

            //adding all the Products to the list
            shop.AddToList(books);
            shop.AddToList(cups);
            shop.AddToList(candies);

            //filling up initial balance for user
            user.SetRandomBalance();

            Console.WriteLine("----------Welcome to the Dreamland shop!----------");

            //printing all Products from the list (shop)
            //shop.PrintAllProducts();

            //printing all types of items available
            //shop.PrintAllTypes();

            //-----------------------------------------------

            var desire = "y";

            while (desire == "y")
            {
                shop.PrintAllSelections();
                var input1 = Console.ReadLine();
                var choice1 = Convert.ToInt32(input1);

                if (choice1 == 1)
                {
                    shop.PrintAllProducts();
                }
                else if (choice1 == 2)
                {
                    Console.WriteLine("You are about to buy something. Pick what you want to buy:");
                    shop.PrintAllTypes(); // nesurisu enumo su objektais, todel negaliu isprintinti tik tu, kurie dar like pardavime

                    var input2 = Console.ReadLine();
                    var choice2 = Convert.ToInt32(input2);

                    // kaip atlikti operacija tik tam pasirinkimui, kurio numeris atitinka enumo numeri -> tai yra, kaip paimti ta objekta, kuris turi butent to enumo verte?

                    if (choice2 == 1)
                    {
                        //casting integer to enum. Negaliu panaudoti metodo vien gaudamas vartotojo ivesti (skaiciu, atitinkanti enuma (attributa) ir ji turinti objekta (book)
                        books.CheckInventory((Type)choice2);
                        if (books.CheckExistance()) // jei nera stoke, tai neduos pasirinkti norimo kiekio
                        {
                            Console.WriteLine($"You are about to buy books. Select desired amount:");
                            var input3 = Console.ReadLine();
                            var choice3 = Convert.ToInt32(input3);
                            if (books.GetPrice() * choice3 <= user.ShowBalance())
                            {
                                if (books.CheckSufficiency(choice3))
                                {
                                    user.Buy((books.GetPrice() * choice3));
                                    books.Sell((Type)choice2, choice3);
                                    Console.WriteLine($"Great! {choice3} added to your basket.");
                                    user.ShowBalance();
                                }
                                else
                                {
                                    Console.WriteLine($"Insufficient stock. Try selecting smaller quantity");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Insufficient funds for selected goods");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"We are out of stock!");
                        }
                    }
                    else if (choice2 == 2)
                    {
                        cups.CheckInventory((Type)choice2);
                        if (cups.CheckExistance())
                        {
                            Console.WriteLine($"You are about to buy cups. Select desired amount:");
                            var input3 = Console.ReadLine();
                            var choice3 = Convert.ToInt32(input3);
                            if (cups.GetPrice() * choice3 <= user.ShowBalance())
                            {
                                if (cups.CheckSufficiency(choice3))
                                {
                                    user.Buy((cups.GetPrice() * choice3));
                                    cups.Sell((Type)choice2, choice3);
                                    Console.WriteLine($"Great! {choice3} added to your basket.");
                                    user.ShowBalance();
                                }
                                else
                                {
                                    Console.WriteLine($"Insufficient stock. Try selecting smaller quantity");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Insufficient funds for selected goods");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"We are out of stock!");
                        }
                    }
                    else if (choice2 == 3)
                    {
                        candies.CheckInventory((Type)choice2);
                        if (candies.CheckExistance())
                        {
                            Console.WriteLine($"You are about to buy candies. Select desired amount:");
                            var input3 = Console.ReadLine();
                            var choice3 = Convert.ToInt32(input3);
                            if (candies.GetPrice() * choice3 <= user.ShowBalance())
                            {
                                if (candies.CheckSufficiency(choice3))
                                {
                                    user.Buy((candies.GetPrice() * choice3));
                                    candies.Sell((Type)choice2, choice3);
                                    Console.WriteLine($"Great! {choice3} added to your basket.");
                                    user.ShowBalance();
                                }
                                else
                                {
                                    Console.WriteLine($"Insufficient stock. Try selecting smaller quantity");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Insufficient funds for selected goods");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"We are out of stock!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Going back to main menu");
                        break;
                    }
                }
                else if (choice1 == 3)
                {
                    Console.WriteLine("You are about to fill up the stock. Pick what you want to bring in:");
                    shop.PrintAllTypes();

                    var input3 = Console.ReadLine();
                    var choice3 = Convert.ToInt32(input3);
                    if (choice3 == 1)
                    {
                        if (books.GetStock() < books.CheckMaxStock())
                        {
                            Console.WriteLine($"You are about to fill up books stock. Maximum allowed stock - {books.CheckMaxStock()}. Select amount:");
                            var input4 = Console.ReadLine();
                            var choice4 = Convert.ToInt32(input4);
                            if (books.CheckMaxStock() >= books.GetStock() + choice4)
                            {
                                books.Fill((Type)choice3, choice4);
                            }
                            else
                            {
                                books.Fill((Type)choice3, books.CheckMaxStock() - books.GetStock());
                                Console.WriteLine($"Book stock is full!");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Book stock is full!");
                        }
                    }
                    else if (choice3 == 2)
                    {
                        if (cups.GetStock() < cups.CheckMaxStock())
                        {
                            Console.WriteLine($"You are about to fill up cup stock. Maximum allowed stock - {cups.CheckMaxStock()}. Select amount:");
                            var input4 = Console.ReadLine();
                            var choice4 = Convert.ToInt32(input4);
                            if (cups.CheckMaxStock() >= cups.GetStock() + choice4)
                            {
                                cups.Fill((Type)choice3, choice4);
                            }
                            else
                            {
                                cups.Fill((Type)choice3, cups.CheckMaxStock() - cups.GetStock());
                                Console.WriteLine($"Cup stock is full!");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Cup stock is full!");
                        }
                    }
                    else if (choice3 == 3)
                    {
                        if (candies.GetStock() < candies.CheckMaxStock())
                        {
                            Console.WriteLine($"You are about to fill up candy stock. Maximum allowed stock - {candies.CheckMaxStock()}. Select amount:");
                            var input4 = Console.ReadLine();
                            var choice4 = Convert.ToInt32(input4);
                            if (candies.CheckMaxStock() >= candies.GetStock() + choice4)
                            {
                                candies.Fill((Type)choice3, choice4);
                            }
                            else
                            {
                                candies.Fill((Type)choice3, candies.CheckMaxStock() - candies.GetStock());
                                Console.WriteLine($"Candy stock is full!");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Candy stock is full!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Going back to main menu");
                        break;
                    }
                }
                else if (choice1 == 4)
                {
                    user.ShowBalance();
                }
                else if (choice1 == 5)
                {
                    Console.WriteLine($"You are about to top up balance. Select amount:");
                    var input = Console.ReadLine();
                    var choice = Convert.ToInt32(input);
                    user.TopUpBalance(choice);
                }
                else if (choice1 == 6)
                {
                    Console.WriteLine("Exiting shop. Bye-bye");
                    desire = "n";
                }
                else
                {
                    Console.WriteLine("Sorry, no such selection. Try again");
                }
            }
        }
    }
}