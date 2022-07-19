using System;

namespace CodeForces
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            for (int i = 0; i < 10; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                if (nums[i] <= 0)
                {
                    nums[i] = 1;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("X[{0}] = {1}", i, nums[i]);
            }
        }
    }
}
