using System;

namespace _002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 1; i < 10; i += 3)
            {
                for (int j = 1; j < 10; j++)
                {
                    for (int k = i; k < (i + 3); k++)
                    {
                        Console.Write($"{k:##}*{j:##} ={k * j:##}\t");
                    }

                    Console.WriteLine();
                }

            }
        }
    }
}