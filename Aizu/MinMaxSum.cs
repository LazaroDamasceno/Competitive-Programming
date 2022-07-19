using System;
using System.Linq;
using System.Collections.Generic;

namespace CompetitiveProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] token;   
            // token = Console.ReadLine().Split(' '); 
            int size = int.Parse(Console.ReadLine());
            long[] nums = new long[size];
            token = Console.ReadLine().Split(' '); 
            for (int i = 0; i < size; i++)
                nums[i] = long.Parse(token[i]);
            Console.WriteLine($"{nums.Min()} {nums.Max()} {nums.Sum()}");
        }
    }
}
