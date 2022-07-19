using System;

namespace CodeForces
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] one = Console.ReadLine().Split();
            string[] two = Console.ReadLine().Split();
            int n = int.Parse(one[0]);
            int k = int.Parse(one[1]);
            int ans = 0;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(two[i]);
            }
            foreach (int el in array)
            {
                if (el >= array[k-1] && el > 0)
                {
                    ans++;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
