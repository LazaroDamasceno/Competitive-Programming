using System;
using System.Linq;
using System.Collections.Generic;

namespace Question
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testcases = int.Parse(Console.ReadLine());
            string first = "";
            string last = "";
            while (testcases > 0)
            {
                string sixdigts = Console.ReadLine();
                first += sixdigts[0]+ sixdigts[1]+ sixdigts[2];
                last += sixdigts[3] + sixdigts[4] + sixdigts[5];
                Console.WriteLine(Convert.ToInt32(first) == Convert.ToInt32(last) ? "Yes" : "No");
                first = "";
                last = "";
                testcases--;
            }
        }
    }
}
