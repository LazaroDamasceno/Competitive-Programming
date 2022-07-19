using System; 

class URI {

    static void Main(string[] args) {
        
        string[] line = Console.ReadLine().Split();
        int a = int.Parse(line[0]);
        int b = int.Parse(line[1]);
        if (a % b == 0 || b % a == 0)   
            Console.WriteLine("Sao Multiplos");
        else 
            Console.WriteLine("Nao sao Multiplos");

    }

}
