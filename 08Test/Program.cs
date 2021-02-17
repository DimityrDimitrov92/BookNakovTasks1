using System;

namespace _08Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //О { x, y}  К({ 0,0}, R = 5).
            Console.Write("Enter x : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write($"Enter y : ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter R : ");
            int r = int.Parse(Console.ReadLine());
            bool inside = (x * x) + (y * y) <= r*r ? true : false;
            if (inside == true)
            {
                Console.WriteLine($"x={x}*{x} + y={y}*{y} = {(x * x) + (y * y)}  R = {r}*{r} = {r*r} =  the point is intside");
            }
            else
            {
                Console.WriteLine($"x={x}*{x} + y={y}*{y} = {(x * x) + (y * y)}  R = {r}*{r} = {r*r} = the point is Outside");
            }
        }
    }
}
