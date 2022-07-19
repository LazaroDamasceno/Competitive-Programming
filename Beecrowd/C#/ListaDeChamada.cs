using System;
using System.Linq;
using System.Collections.Generic;

namespace Others
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var token = Console.ReadLine().Split(' ');
            var numberStudents = int.Parse(token[0]);
            var choosenNum = int.Parse(token[1]);
            var students = new String[numberStudents];
            for (int i = 0; i < numberStudents; i++)
                students[i] = Console.ReadLine();
            Array.Sort(students);
            Console.WriteLine(students[--choosenNum]);
        }
    }
}
