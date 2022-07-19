using System; 

class URI {

    static void Main(string[] args) { 

        int sum = int.Parse(Console.ReadLine());
        
        int n001 = (((((sum % 100) % 50) % 20) % 10) % 5) % 2;
        int n002 = (((((sum % 100) % 50) % 20) % 10) % 5) / 2;
        int n005 = ((((sum % 100) % 50) % 20) % 10) / 5;
        int n010 = (((sum % 100) % 50) % 20) / 10;
        int n020 = ((sum % 100) % 50) / 20;
        int n050 = (sum % 100) / 50;
        int n100 = sum / 100; 
        
        Console.WriteLine(sum);
        Console.WriteLine($"{n100} nota(s) de R$ 100,00");
        Console.WriteLine($"{n050} nota(s) de R$ 50,00");
        Console.WriteLine($"{n020} nota(s) de R$ 20,00");
        Console.WriteLine($"{n010} nota(s) de R$ 10,00");
        Console.WriteLine($"{n005} nota(s) de R$ 5,00");
        Console.WriteLine($"{n002} nota(s) de R$ 2,00");
        Console.WriteLine($"{n001} nota(s) de R$ 1,00");

    }

}
