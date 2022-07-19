using System;

namespace _486a
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            Console.WriteLine((input % 2 == 0) ? (input / 2) : -((input / 2) + 1));
        }
    }
}
