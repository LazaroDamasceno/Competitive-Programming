using System;

namespace CodeForcesResolution
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] input = Console.ReadLine().Split();
			int Limak = int.Parse(input[0]);
			int Bob = int.Parse(input[1]);
			int count = 0;
			while (Limak <= Bob)
			{
				Limak *= 3;
				Bob *= 2;
				count++;
			}
            Console.WriteLine(count);
		}
    }
}
