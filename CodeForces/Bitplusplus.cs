using System;

namespace Bit__
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            int x = 0;
            while (cases != 0) 
            {
                string input = Console.ReadLine();
                if (input[0] == '+' || input[2] == '+')
                {
                    x++;
                } 
                else 
                {
                    x--;
                }
                cases--;
            }
            Console.WriteLine(x);
        }
    }
}
