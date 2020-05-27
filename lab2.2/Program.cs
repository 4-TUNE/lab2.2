using System;

namespace oopLaba2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|     x     |    y=f(x)   |");
            double a = 1.25, b = 6.75;
            double y;
            double x = a;
            while (b > x)
            {
                y = Math.Pow(x, 1.0/4.0);
                x = x + 0.25;
                Console.WriteLine(x + "\t    " + y);
            }
        }
    }
}
