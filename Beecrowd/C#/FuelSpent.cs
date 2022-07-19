using System; 

class URI {

    static void Main(string[] args) { 

        int givenDistance = int.Parse(Console.ReadLine());
        int averageSpeed = int.Parse(Console.ReadLine());
        int fullDistance = givenDistance * averageSpeed;
        double answer = (fullDistance*1.0) / 12;
        Console.WriteLine($"{answer:.000}");

    }

}
