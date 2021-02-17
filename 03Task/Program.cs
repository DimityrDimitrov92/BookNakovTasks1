using System;

namespace _03Task
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Enter int num : ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine((a / 100) % 10 == 7 ? "the third digit from right to left is 7" : "the third digit from right to left is not 7");
            }
        }
    }
}
