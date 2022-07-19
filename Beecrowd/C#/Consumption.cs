using System; 

class URI {

    static void Main(string[] args) { 

        int distance = int.Parse(Console.ReadLine());
        double fuel = double.Parse(Console.ReadLine());
        Console.WriteLine($"{((distance*1.0)/fuel):.000} km/l");

    }

}
