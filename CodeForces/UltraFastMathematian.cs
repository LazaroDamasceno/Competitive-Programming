using System;

namespace _61a
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = Console.ReadLine();
            string two = Console.ReadLine();
            string ans = "";
            for (int i = 0; i < one.Length; i++)
            {
                if (one[i] != two[i])
                {
                    ans += '1';
                } else
                {
                    ans += '0';
                }
            }
            Console.WriteLine(ans);
        }
    }
}
