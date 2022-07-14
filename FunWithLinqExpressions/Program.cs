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
            Array objs = GetProjectedSubset(itemsInStock);
            foreach (object o in objs)
                Console.WriteLine(o);
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
            var overstock = from p in products where p.NumberInStock > 25 select p;
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
        static Array GetProjectedSubset(ProductInfo[] products)
        {
            var nameDesc = from p in products select new { p.Name, p.Description };
            return nameDesc.ToArray();
        }
        static void GetСountFromQuery()
        {
            string[] currentVideoGames =
            {
                "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2"
            };
            // Получить количетсво элементов, чья длина больше 6-ти символов.
            int numb = (from g in currentVideoGames where g.Length > 6 select g).Count();
            Console.WriteLine("{0} items honor the LINQ query.", numb);
        }
        static void ReverseEverything(ProductInfo[] products)
        {
            Console.WriteLine("Product in reverse:");
            var allProducts = from p in products select p;
            foreach(var prod in allProducts.Reverse())
                Console.WriteLine(prod.ToString());
        }
        static void AlphabetizeProductNames(ProductInfo[] products)
        {
            // Получить названия товаров в алфавитном порядке.
            var subset = from p in products orderby p.Name select p;
            Console.WriteLine("Ordered by Name:");
            foreach(var p in subset)
                Console.WriteLine(p.ToString());
        }
    }
}
