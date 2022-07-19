using System; 

class URI {

    static void Main(string[] args) { 

            string[] one = Console.ReadLine().Split();
            string[] two = Console.ReadLine().Split();
            double x1 = double.Parse(one[0]);
            double y1 = double.Parse(one[1]);
            double x2 = double.Parse(two[0]);
            double y2 = double.Parse(two[1]);
            double distance = Math.Sqrt((Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2)));
            Console.WriteLine($"{distance:.0000}");

    }

}
