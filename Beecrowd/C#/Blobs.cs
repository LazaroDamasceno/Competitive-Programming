using System;
using System.Collections.Generic;
using System.Linq;

namespace CompetitiveProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcases = int.Parse(Console.ReadLine());
            int counter = 0;
            while (testcases != 0)
            {
                double weigths = double.Parse(Console.ReadLine());
                while (weigths > 1)
                {
                    weigths /= 2;
                    counter++;
                }
                Console.WriteLine($"{counter} dias");
                counter = 0;
                testcases--;
            }
        }
    }
}
