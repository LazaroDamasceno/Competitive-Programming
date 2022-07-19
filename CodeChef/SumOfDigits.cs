using System;
using System.Linq;
using System.Collections.Generic;

namespace InCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int testcases = int.Parse(Console.ReadLine());
            while (testcases > 0)
            {
                int number = int.Parse(Console.ReadLine());
                while (number >= 1)
                {
                    counter += number % 10;
                    number /= 10;
                }
                Console.WriteLine(counter);
                counter = 0;
                testcases--;
            }
        }
    }
}
