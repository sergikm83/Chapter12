using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqOverArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with LINQ to Objects *****\n");
            QueryOverStrings();
        }
        static void QueryOverStrings()
        {
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
            IEnumerable<string> subset = from g in currentVideoGames
                                         where g.Contains(" ")
                                         orderby g
                                         select g;
            foreach (string s in subset)
                Console.WriteLine("Item: {0}", s);
        }
        static void QueryOverStnngsWithExtensionMethods()
        {
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
            IEnumerable<string> subset = currentVideoGames.Where(g => g.Contains(" ")).OrderBy(g => g).Select(g => g);
            foreach (string s in subset)
                Console.WriteLine("Item: {0}", s);
        }
        static void ReflectOverQueryResults(object resultSet, string queryType = "Query Expressions")
        {
            Console.WriteLine($"***** Info about your query using {queryType} *****");
            // Вывести тип результирующего набора
            Console.WriteLine("resultSet is of type: {0}",resultSet.GetType().Name);
            // Вывести местоположение результирующего набора
            Console.WriteLine("resultSet location: {0}",
                resultSet.GetType().Assembly.GetName().Name);
        }
    }
}
