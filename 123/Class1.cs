using System;
namespace _123 { 

class Program
{

    static void Main(string[] args)
    {
        double meal_cost = 100;
        int tip_percent = 15;
        int tax_percent = 8;

        int a = (int)meal_cost;

        int sum = tax_percent + tip_percent + a;
        Console.WriteLine("用餐總費用:" + sum);
    }
}
    }
