using System;
using System.Linq;
using System.Collections.Generic;

namespace InCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string[] token;
            int testcases = int.Parse(Console.ReadLine());
            while (testcases > 0)
            {
                // token = Console.ReadLine().Split(' ');
                int number = int.Parse(Console.ReadLine());
                int[] digits = new int[number.ToString().Length];
                int index = 0;
                while (number >= 1)
                {
                    digits[index++] = number % 10;
                    number /= 10;
                }
                Console.WriteLine(digits[0] + digits[digits.Length-1]);
                testcases--;
            }
        }
    }
}
