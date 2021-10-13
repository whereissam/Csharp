using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string, int> action = new Action<string, int>(SayHello);
            action("TIm", 20);

            //Func<int, int, int> func = new Func<int, int, int>(Add);
            //int res = func(100, 200);
            //Console.WriteLine(res);

            var func = new Func<double, double, double>(Mul);
            double res = func(3.0, 4.0);
            Console.WriteLine(res);
        }

        static void M1()
        {
            Console.WriteLine("M1 is called");
        }

        static void SayHello(string name1, int num2)
        {
            Console.WriteLine($"Hello, {name1} and {num2}!");
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static double Mul(double x, double y)
        {
            return x * y;
        }
    }
}

