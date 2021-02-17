using System;

namespace _02Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter int number : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine((a % 5 == 0 && a % 7 ==0)?$"This number is divided by 5 and 7" :$"This number is not divisible by 5 or 7");
            Console.ReadLine();
        }
    }
}
