using System; 

class URI {

    static void Main(string[] args) { 

        int input = int.Parse(Console.ReadLine());
        for (int n = 2; n <= input; n = n + 2)
        {
            Console.WriteLine($"{n}^2 = {n*n}");
        }

    }

}
