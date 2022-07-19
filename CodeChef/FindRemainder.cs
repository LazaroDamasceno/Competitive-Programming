using System;
using System.Linq;
using System.Collections;

namespace InCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] token;
            int testcases = int.Parse(Console.ReadLine());
            while (testcases > 0)
            {
                token = Console.ReadLine().Split(' ');
                int A = int.Parse(token[0]);
                int B = int.Parse(token[1]);
                Console.WriteLine(A % B);
                testcases--;
            }
        }
    }
}
