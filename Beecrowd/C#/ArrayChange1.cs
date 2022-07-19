using System;
using System.Linq;
using System.Collections.Generic;

namespace Beecrownd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] collection = new int[20];
            int index = 0;
            while (index != 20) collection[index++] = int.Parse(Console.ReadLine());
            Array.Reverse(collection);
            for (int i = 0; i < collection.Length; i++)
            {
                Console.WriteLine("N[{0}] = {1}", i, collection[i]);
            }
        }
    }
}
