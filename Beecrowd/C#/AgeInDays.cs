using System; 

class URI {

    static void Main(string[] args) { 

            int ageInDays = int.Parse(Console.ReadLine());
            int years = ageInDays / 365;
            int months = (ageInDays % 365) / 30;
            int days = ageInDays;
            days -= years * 365;
            days -= months * 30;
            Console.WriteLine($"{years} ano(s)");
            Console.WriteLine($"{months} mes(es)");
            Console.WriteLine($"{days} dia(s)");

    }

}
