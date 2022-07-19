using System;
using System.Linq;
using System.Collections.Generic;

namespace Others
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            var numberLeds = new Dictionary<char, int>() 
            { 
                {'0', 6}, 
                {'1', 2}, 
                {'2', 5}, 
                {'3', 5}, 
                {'4', 4}, 
                {'5', 5}, 
                {'6', 6}, 
                {'7', 3}, 
                {'8', 7}, 
                {'9', 6} 
            };
            int testcases = int.Parse(Console.ReadLine());
            while (testcases != 0)
            {
                var number = Console.ReadLine();
                for (int i = 0; i < number.Length; i++)
                {
                    count += numberLeds[number[i]];
                }
                Console.WriteLine(count + " leds");
                count = 0;
                testcases--;
            }
        }
    }
}
