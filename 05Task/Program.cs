using System;

namespace _05Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter h : ");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine($"The Formula is  S = (a + b) * h / 2  =   "+ (int)(a + b) * h / 2);
        }
    }
}
