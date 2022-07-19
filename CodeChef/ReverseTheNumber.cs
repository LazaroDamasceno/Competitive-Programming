using System;
using System.Linq;
using System.Collections;

namespace InCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] token;
            int newNum = 0;
            int testcases = int.Parse(Console.ReadLine());
            while (testcases > 0)
            {
                int number = int.Parse(Console.ReadLine());
                int power10 = Convert.ToInt32(Math.Pow(10, number.ToString().Length-1));
                while (number >= 1)
                {
                    newNum += (number % 10) * power10;
                    number /= 10;
                    power10 /= 10;
                }
                Console.WriteLine(newNum);
                newNum = 0;
                testcases--;
            }
        }
    }
}
