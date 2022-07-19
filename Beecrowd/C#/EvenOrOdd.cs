using System;
using System.Linq;
using System.Collections.Generic;

namespace Beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcases = int.Parse(Console.ReadLine());
            while (testcases != 0)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > 0)
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                }
                else if (number < 0)
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }   
                }
                else
                {
                    Console.WriteLine("NULL");
                }
                testcases--;
            }
        }
    }
}
