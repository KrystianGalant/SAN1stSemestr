using Datebase.backend;
using view.frontend;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace shopping.backend
{
    public class ShoppingCart
    {
        private List<Product> products;
        private decimal totalPrice;
        private decimal totalPriceBrutto;
        private decimal Vat;
        public ShoppingCart()
        {
            products = new List<Product>();
            totalPrice = 0m;
            totalPriceBrutto = 0m;
            Vat = 0.23m;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
            totalPrice = Math.Round(totalPrice, 2) + Math.Round((product.NetPrice), 2);
            BonusesOnScreen.HorizontalEmptySpace();
            Console.WriteLine($"You added to cart: {product.Name} - Prize(netto): {product.NetPrice}");
 
            totalPriceBrutto += product.NetPrice + Math.Round((product.NetPrice * Vat),2) ; // Adding price with VAT
                                                                                            // totalPriceBrutto = Math.Round(totalPriceBrutto, 2);
            BonusesOnScreen.HorizontalEmptySpace();
            Console.WriteLine($"Here is the total sum of your purchases.(brutto): {totalPriceBrutto} PLN");
            BonusesOnScreen.HorizontalEmptySpace();
        }

            public void DisplayReceipt()
        {//Yes, it probably should go into the Display file, but since I worked on this file much earlier, making changes now would be additional work.
            Console.WriteLine("Receipt for the purchases:");
            BonusesOnScreen.HorizontalLine();
            Console.WriteLine($"Data: {DateTime.Now}");
            BonusesOnScreen.HorizontalLine();
            foreach (var product in products)
                {
                    Console.WriteLine($"{product.Name} - Gross price: {Math.Round( product.NetPrice * (1+ Vat), 2) } PLN");
                }
                decimal totalVat = Math.Round( totalPriceBrutto - totalPrice, 2); // Calculate total VAT
            BonusesOnScreen.HorizontalLine();
            Console.WriteLine($"Total gross price(brutto): {totalPriceBrutto} PLN");
            BonusesOnScreen.HorizontalLine();
            Console.WriteLine($"Total VAT: {totalVat} PLN");
            BonusesOnScreen.HorizontalLine();
            Console.WriteLine("Thank you for your purchase, and we hope to see you again soon.!");
            totalPrice = 0m;
            totalPriceBrutto = 0m;
        }

        }
}
