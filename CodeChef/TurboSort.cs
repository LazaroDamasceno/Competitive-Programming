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
            int[] nums = new int[size];
            for (int i = 0; i < size; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(nums); ;
            foreach (var i in nums)
            {
                Console.WriteLine(i);
            }
        }
    }
}
