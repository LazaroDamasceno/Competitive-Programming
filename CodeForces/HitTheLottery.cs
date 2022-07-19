using System;

namespace CodeForcesResolution
{
    class Program
    {
        static void Main(string[] args)
        {
			int sum = int.Parse(Console.ReadLine());
			int ans = 0;
			int b001 = ((((sum % 100) % 20) % 10) % 5);
			int b005 = (((sum % 100) % 20) % 10) / 5;
			int b010 = ((sum % 100) % 20) / 10;
			int b020 = (sum % 100) / 20;
			int b100 = sum / 100;
			ans += b001;
			ans += b005;
			ans += b010;
			ans += b020;
			ans += b100;
            Console.WriteLine(ans);
		}
    }
}
