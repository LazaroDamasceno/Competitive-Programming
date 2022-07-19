using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            int ans = 0;
            for (int i = 1; i <= cases; i++)
            {
                string[] input = Console.ReadLine().Split();
                int p = int.Parse(input[0]);
                int q = int.Parse(input[1]);
                if (p + 2 <= q)
                {
                    ans++;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
