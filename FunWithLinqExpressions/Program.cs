using System;
using System.Linq;

namespace FunWithLinqExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Query Expressions *****\n");
            // Создадим массив для тестов...
            ProductInfo[] itemsInStock = new[]
            {
                new ProductInfo
                {
                    Name = "Mac's Coffee",
                    Description = "Coffee with TEETH",
                    NumberInStock = 24
                },
                new ProductInfo
                {
                    Name = "Milk Maid Milk",
                    Description = "Milk cow's love",
                    NumberInStock = 100
                },
                new ProductInfo
                {
                    Name = "Pure Silk Tofu",
                    Description = "Bland as Possible",
                    NumberInStock = 120
                },
                new ProductInfo
                {
                    Name = "Crunchy Pops",
                    Description = "Cheezy, peppery goodness",
                    NumberInStock = 2
                },
                new ProductInfo
                {
                    Name = "RipOff Water",
                    Description = "From the tap to your wallet",
                    NumberInStock = 100
                },
                new ProductInfo
                {
                    Name = "Classic Valpo Pizza",
                    Description = "Everyone loves pizza",
                    NumberInStock = 73
                }
            };
            // Здесь будем вызывать разнообразные методы!!!

        }

        static void SelectEverything(ProductInfo[] products)
        {
            // Получить все!
            Console.WriteLine("All product details:");
            var allProducts = from p in products select p;
            foreach (var prod in allProducts)
                Console.WriteLine(prod.ToString());
        }
        static void ListProductNames(ProductInfo[] products)
        {
            // Получить только наименования товаров
            Console.WriteLine("Only product names:");
            var names = from p in products select p.Name;
            foreach (var n in names)
                Console.WriteLine("Name: {0}", n);
        }
        static void GetOverStock(ProductInfo[] products)
        {
            Console.WriteLine("The overstock items!");
            // Получить товары со складским запасом более 25 единиц.
            var overstock = from p in products where p.NumberInStock>25 select p;
            foreach (var o in overstock)
                Console.WriteLine(o.ToString());
        }
        static void GetNamesAndDescriptions(ProductInfo[] products)
        {
            Console.WriteLine("Names and Descriptions:");
            var nameDesc = from p in products select new { p.Name, p.Description };
            foreach (var item in nameDesc)
                Console.WriteLine(item.ToString());
        }
    }
}
