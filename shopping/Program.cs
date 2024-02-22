using System;
using System.Collections.Generic;
using Datebase.backend;
using questions.backend;
using shopping.backend;
using view.frontend;



public class Program
{
    public static void Main(string[] args)
    {
        Work DeclaringWork= new Work();
        bool working = true;
        ShoppingCart cart = new ShoppingCart();
        
        Console.WriteLine("Welcome");

        while (working)
        {
            Console.WriteLine("To add a product to your cart, please provide the barcode of the product, or press 'P' to finish shopping.");
            Console.WriteLine("To view the list, press 'L'.");
            BonusesOnScreen.HorizontalEmptySpace();
            string userInput = Console.ReadLine().ToUpper(); // even if you press enter or 0 it will not work, and it should show error.

            switch (userInput)
            {
                case "P"://P like word "Paragon"
                    cart.DisplayReceipt();

                  //ask if you want to end.
                    working = DeclaringWork.DoYouWantToEndWork();


                    break;

                case "L":
                    Product.ShowProductList();
                    break;

                default:
                    if (Product.productsDatabase.TryGetValue(userInput, out Product product))
                        //it works but i don't know for now how to stop it from giving me "CS8600  Converting null literal or possible null value to non - nullable type"
                    {//it will add a product to cart if such product exist and then show the name and prize of it.
                        cart.AddProduct(product);
                    }
                    else
                    {//error.
                        Console.WriteLine("ERROR WRONG BARCODE/NIEPRAWIDŁOWY KOD KRESKOWY");
                    }
                    break;
            }
        }
    }
}
