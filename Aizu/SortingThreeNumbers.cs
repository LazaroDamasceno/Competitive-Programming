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
            token = Console.ReadLine().Split(' '); 
            int[] nums = new int[3];
            nums[0] = int.Parse(token[0]);
            nums[1] = int.Parse(token[1]);
            nums[2] = int.Parse(token[2]);
            Array.Sort(nums);
            Console.WriteLine(nums[0] + " " + nums[1] + " " + nums[2]);
        }
    }
}
