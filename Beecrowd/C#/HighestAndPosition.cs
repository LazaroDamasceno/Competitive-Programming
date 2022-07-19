using System;
using System.Linq;
using System.Collections.Generic;

namespace Beecrowd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[100];
            for (int i = 0; i < 100; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(nums.Max());
            Console.WriteLine(Array.IndexOf(nums, nums.Max())+1);
        }
    }
}
