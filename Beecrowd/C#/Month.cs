using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 

        int month = int.Parse(Console.ReadLine());
        Dictionary<int, string> months = new Dictionary<int, string>();
        months.Add(1, "January");
        months.Add(2, "February");
        months.Add(3, "March");
        months.Add(4, "April");
        months.Add(5, "May");
        months.Add(6, "June");
        months.Add(7, "July");
        months.Add(8, "August");
        months.Add(9, "September");
        months.Add(10, "October");
        months.Add(11, "November");
        months.Add(12, "December");
        Console.WriteLine(months[month]);

    }

}
