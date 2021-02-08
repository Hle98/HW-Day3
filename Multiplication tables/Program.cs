using System;

namespace Multiplication_tables
{
    class Program
    {
        static void Main(string[] args)
        {
            
           for (int i = 1; i<=12; i++)
            {
                for (int j = 1; j <= 10; j++) 
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                    Console.WriteLine();
                    
                }
            }
        }
    }
}
