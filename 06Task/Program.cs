using System;

namespace _06Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a : ");
            double a = int.Parse(Console.ReadLine()); 
            Console.Write("Enter b : ");
            double b = int.Parse(Console.ReadLine()); 
            Console.Write("Enter c : ");
            double c = int.Parse(Console.ReadLine());
            Console.Write("Enter h : ");
            double h = int.Parse(Console.ReadLine());
            Console.WriteLine($"S =(a/2)*h =   " + (double)(a/2)*h);
            Console.WriteLine($"P = a+b+c  =    " + (double)(a+b+c) );
        }
    }
}
