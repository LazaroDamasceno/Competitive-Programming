using System;
using System.Linq;
using System.Collections.Generic;

namespace CompetitiveProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string[] token = Console.ReadLine().Split(' ');
            int testcases = int.Parse(Console.ReadLine());
            int[] nums = new int[testcases];
            for (int i = 0; i < testcases; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(nums);
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
