using System;

namespace _01Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some int number : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine((a % 2 == 0)?$"It's even number !" : "It's odd number ! ");
        }
    }
}
