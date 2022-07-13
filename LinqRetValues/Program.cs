using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqRetValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static IEnumerable<string> GetStringSubset()
        {
            string[] colors = {"Black","Light Red", "Green", "White",
            "Yellow", "Dark Red","Pink","Purple","Silver","Red"};
            IEnumerable<string> theRedColors = from c in colors where c.Contains("Red") select c;
            return theRedColors;
        }
    }
}
