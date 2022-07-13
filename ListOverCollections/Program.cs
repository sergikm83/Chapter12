using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOverCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** LINQ over Generic Collections *****\n");
            // Создать список List<> объектов Car.
            List<Car> myCars = new List<Car>()
            {
                new Car { PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW" },
                new Car { PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW" },
                new Car { PetName = "Mary", Color = "Black", Speed = 55, Make = "VW" },
                new Car { PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo" },
                new Car { PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford" }
            };
        }
        static void GetFastCars(List<Car> myCars)
        {
            // Найти в List<> все объекты Car, у которых значение Speed больше 55.
            var fastCars = from c in myCars where c.Speed > 55 select c;
            foreach(var car in fastCars)
                Console.WriteLine($"{car.PetName} is going too fast!");
        }
        static void GetFastBMWs(List<Car> myCars)
        {
            // Найти быстрые BMW :)
            var fastCars = from c in myCars where c.Speed > 55 && c.Make=="BMW" select c;
            foreach (var car in fastCars)
                Console.WriteLine($"{car.PetName} is going too fast!");
        }
    }
}
