using System;
using System.Linq;
using System.Collections.Generic;

namespace CompetitiveProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] token;
            // token = Console.ReadLine().Split(' ');
            int testcases = int.Parse(Console.ReadLine());
            while (testcases != 0)
            {
                token = Console.ReadLine().Split(' ');
                int quantity = int.Parse(token[0]);
                int price = int.Parse(token[1]);
                Console.WriteLine(quantity > 1000 ? (quantity * price * 0.9) : (quantity * price * 1.0));
                testcases--;
            }
        }
    }
}
