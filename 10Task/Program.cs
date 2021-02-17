using System;

namespace _10Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0x7DB;
            int a = i % 10;
            int b = (i / 10) % 10;
            int c = (i / 100) % 10;
            int d = (i / 1000) % 10;
            Console.WriteLine(i);
            Console.WriteLine(a+b+c+d);
            Console.WriteLine(""+a+b+c+d);
            Console.WriteLine(""+a+d+c+b);
            Console.WriteLine(""+d+b+c+a);
        }
    }
}
