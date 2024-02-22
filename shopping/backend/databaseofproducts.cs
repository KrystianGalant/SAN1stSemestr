using System;

namespace Datebase.backend
{
    public class Product
    {
        public string Barcode { get; }
        public string Name { get; }
        public decimal NetPrice { get; }

        public Product(string barcode, string name, decimal netPrice)
        {
            Barcode = barcode;
            Name = name;
            NetPrice = netPrice;
        }
        
        public static Dictionary<string, Product> productsDatabase = new Dictionary<string, Product>()
    {
        { "001", new Product("001", "Masło extra", 6.50m) },
        { "002", new Product("002", "Chleb wiejski", 4.50m) },
        { "003", new Product("003", "Makaron Babuni", 9.20m) },
        { "004", new Product("004", "Dżem truskawkowy", 8.10m) },
        { "005", new Product("005", "Kiełbasa myśliwska", 29.00m) },
        { "006", new Product("006", "Szynka konserwowa", 22.00m) },
        { "007", new Product("007", "Chipsy paprykowe", 6.00m) },
        { "008", new Product("008", "Serek wiejski", 3.50m) },
        { "009", new Product("009", "Sól kuchenna", 2.70m) },
        { "010", new Product("010", "Cukier kryształ", 3.20m) }
    };

        public static void ShowProductList()
        {
            Console.WriteLine("List of Products:");
            foreach (var showproducts in Product.productsDatabase)
            {
                Console.WriteLine($"Kod: {showproducts.Key}, Nazwa: {showproducts.Value.Name}, Cena netto: {showproducts.Value.NetPrice} PLN");
            }
        }
    }
}