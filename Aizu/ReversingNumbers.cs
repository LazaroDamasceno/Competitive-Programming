using System;
using System.Linq;
using System.Collections.Generic;

namespace CompetitiveProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] token;
            // token = Console.ReadLine().Split(' ');
            var size = int.Parse(Console.ReadLine());
            var nums = new int[size];
            token = Console.ReadLine().Split(' ');
            for (int i = 0; i < size; i++)
                nums[i] = int.Parse(token[i]);
            Array.Reverse(nums);
            for (int i = 0; i <= size-2; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.Write(nums[size-1]);
            Console.WriteLine();
        }
    }
}
