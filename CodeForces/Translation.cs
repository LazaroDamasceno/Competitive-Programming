using System;

namespace _41a
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = Console.ReadLine();
            string two = Console.ReadLine();
            int size = two.Length - 1;
            bool ans = true;
            for (int i = 0; i < one.Length; i++)
            {
                if (one[i] == two[size])
                {
                    ans = true;
                } else
                {
                    ans = false;
                    break;
                }
                size--;
            }
            Console.WriteLine(ans == true ? "YES" : "NO");
        }
    }
}
