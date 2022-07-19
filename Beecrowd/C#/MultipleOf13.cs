using System;
using System.Linq;
using System.Collections.Generic;

namespace UriOnlineJudge
{
    class Program 
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] nums = new int[2];
            nums[0] = int.Parse(Console.ReadLine());
            nums[1] = int.Parse(Console.ReadLine());
            for (int i = nums.Min(); i <= nums.Max(); i++)
                if (i % 13 != 0)
                    sum += i;
            Console.WriteLine(sum);
        }
    }
}
