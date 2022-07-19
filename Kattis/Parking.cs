using System;
using System.Linq;
using System.Collections.Generic;

namespace CompetitiveProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] token;
            int testCases = int.Parse(Console.ReadLine());
            int[] stores;
            while (testCases > 0)
            {
                int numberStore = int.Parse(Console.ReadLine());
                stores = new int[numberStore];
                token = Console.ReadLine().Split();
                for (int i = 0; i < numberStore; i++)
                {
                    stores[i] = int.Parse(token[i]);
                }
                Console.WriteLine((stores.Max() - stores.Min()) * 2);
                testCases--;
            }
        }
    }
}
