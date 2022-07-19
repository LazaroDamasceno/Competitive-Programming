using System;
using System.Linq;
using System.Collections.Generic;

namespace CompetitiveProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];
            string[] token = Console.ReadLine().Split(' ');
            for (int i = 0; i < size; i++)
                numbers[i] = int.Parse(token[i]);
            Console.WriteLine(numbers.Sum());
        }
    }
}
