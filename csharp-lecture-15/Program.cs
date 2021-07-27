using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace csharp_lecture_15
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var shop = new Shop();
            var user = new User();
            user.SetRandomBalance();

            Console.WriteLine("----------Welcome to the Dreamland shop!----------");
            shop.PrintAllProducts();

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
                    shop.PrintAllTypes();

                    var input2 = Console.ReadLine();
                    var choice2 = Convert.ToInt32(input2);

                    var productToBuy = shop.GetProductById(choice2);
                    if (productToBuy != null)
                    {
                        productToBuy.CheckInventory((Type)choice2);
                        if (productToBuy.CheckExistance()) // jei nera stoke, tai neduos pasirinkti norimo kiekio
                        {
                            Console.WriteLine($"You are about to buy {(Type)choice2}. Select desired amount:");
                            var input3 = Console.ReadLine();
                            var choice3 = Convert.ToInt32(input3);
                            if (productToBuy.GetPrice() * choice3 <= user.ShowBalance())
                            {
                                if (productToBuy.CheckSufficiency(choice3))
                                {
                                    user.Buy((productToBuy.GetPrice() * choice3));
                                    shop.Sell(choice2, choice3);
                                    Console.WriteLine($"Great! {choice3} added to your basket.");
                                    //user.ShowBalance();
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
                            Console.WriteLine($"We are out of {(Type)choice2} stock!");
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

                    var productToBuy = shop.GetProductById(choice3);

                    if (productToBuy != null)
                    {
                        if (productToBuy.GetStock() < productToBuy.CheckMaxStock())
                        {
                            Console.WriteLine($"You are about to fill up {(Type)choice3} stock. Maximum allowed stock - {productToBuy.CheckMaxStock()}. Select amount:");
                            var input4 = Console.ReadLine();
                            var choice4 = Convert.ToInt32(input4);
                            if (productToBuy.CheckMaxStock() >= productToBuy.GetStock() + choice4)
                            {
                                shop.Fill(choice3, choice4);
                            }
                            else
                            {
                                shop.Fill(choice3, productToBuy.CheckMaxStock() - productToBuy.GetStock());
                                Console.WriteLine($"{(Type)choice3} stock is full!");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{(Type)choice3} stock is full!");
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