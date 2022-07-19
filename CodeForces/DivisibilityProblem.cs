using System;

namespace A_Divisibility_Problem
{
    class Program
    {   
        static void Answer()
        {
            int cases = int.Parse(Console.ReadLine());
            while (cases != 0)
            {
                string[] i = Console.ReadLine().Split();
                int a = int.Parse(i[0]);
                int b = int.Parse(i[1]);
                Console.WriteLine((a % b == 0) ? (a % b) : (b - a % b));
                cases--;
            }
        }

        static void Main(string[] args)
        {
            Answer();
        }
    }
}
