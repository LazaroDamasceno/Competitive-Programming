using System;
using System.Linq;
using System.Collections.Generic;

namespace CompetitiveProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] token;
            // token = Console.ReadLine().Split(' ');
            int sum = 0;
            int number = int.Parse(Console.ReadLine());
            if (number > 1)
            {
                for (int i = 1; i <= number; i++)
                {
                    sum += i;
                }
            }
            else
            {
                for (int i = 1; i >= number; i--)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
