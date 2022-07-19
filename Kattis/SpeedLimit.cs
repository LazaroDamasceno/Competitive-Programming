using System;
using System.Linq;
using System.Collections.Generic;

namespace Question
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distance = 0;
            List<int> speed = new List<int>();
            List<int> time = new List<int>();
            while (true)
            {
                int size = int.Parse(Console.ReadLine());
                if (size == -1) break;
                for (int i = 0; i < size; i++)
                {
                    string[] token = Console.ReadLine().Split();
                    speed.Add(int.Parse(token[0]));
                    time.Add(int.Parse(token[1]));
                }
                int index1 = 0;
                int index2 = index1 + 1;
                distance += speed[0] * time[0];
                for (int i = 1; i < size; i++)
                {
                    distance += speed[i] * (time[index2] - time[index1]);
                    index1++;
                    index2++;
                }
                Console.WriteLine(distance + " miles");
                speed.Clear();
                time.Clear();
                distance = 0;
            }
        }
    }
}
