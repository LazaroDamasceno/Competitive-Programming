using System;

namespace CodeForcesResolution
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] digits = new int[4];
			int year = int.Parse(Console.ReadLine());
			++year;
			digits[0] = year / 1000;
			digits[1] = (year % 1000) / 100;
			digits[2] = (year % 100) / 10;
			digits[3] = year % 10;
			while (digits[0] == digits[1]
					|| digits[0] == digits[2]
					|| digits[0] == digits[3]
						|| digits[1] == digits[2]
						|| digits[1] == digits[3]
						|| digits[2] == digits[3])
			{
				++year;
				digits[0] = year / 1000;
				digits[1] = (year % 1000) / 100;
				digits[2] = (year % 100) / 10;
				digits[3] = year % 10;
			}
            Console.WriteLine(year);
		}
    }
}
