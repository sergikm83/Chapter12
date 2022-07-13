using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqRetValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** LINQ Return Values *****\n");
            IEnumerable<string> subset = GetStringSubset();
            foreach(var item in subset)
                Console.WriteLine(item);
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
