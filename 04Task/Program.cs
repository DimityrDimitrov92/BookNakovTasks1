using System;

namespace _04Task
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num = 4;
            bool bit3 = (num & 8) != 0;
            Console.WriteLine(bit3);
            Console.ReadLine();
        }
    }
}
