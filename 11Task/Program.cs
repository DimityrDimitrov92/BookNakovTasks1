using System;

namespace _11Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 35; 
            int p = 6;
            int i = 1; 
            int mask = i << p; 
            Console.WriteLine((n & mask) != 0 ? 1 : 0);

        }
    }
}
