using System;
using System.Collections.Generic;
using System.Linq;

namespace CompetitiveProgramming
{
    class Programa
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = input;
                input *= 2;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"N[{i}] = {numbers[i]}");
            }
        }
    }
}
