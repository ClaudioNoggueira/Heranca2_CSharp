using Entities;
using System;
using System.Collections.Generic;

namespace Heranca2_CSharp {
    class Program {
        static void Main(string[] args) {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int qtdProducts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdProducts; i++) {
                Console.WriteLine("\nProduct #" + i + " data:");
                Console.Write("Commom, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string productName = Console.ReadLine();

                Console.Write("Price: ");
                double productPrice = double.Parse(Console.ReadLine());

                switch (ch) {
                    case 'c':
                        Product product = new Product(productName, productPrice);
                        products.Add(product);
                        break;
                    case 'i':
                        Console.Write("Customs fee: ");
                        double fee = double.Parse(Console.ReadLine());
                        products.Add(new ImportedProduct(productName, productPrice, fee));
                        break;
                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime manufactureDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                        products.Add(new UsedProduct(productName, productPrice, manufactureDate));
                        break;
                }
            }
            foreach (Product item in products) {
                Console.WriteLine("\nPRICE TAGS");
                Console.WriteLine(item.PriceTag());
            }
        }
    }
}
