using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program

    {
        public delegate double Delegatechis(double x, double y);
        public static double Min(double a, double b)
        {
            return a < b ? a : b;
        }
        public static double Max(double a, double b)
        {
            return a > b ? a : b;
        }
        static void Main(string[] args)
        {
            double a = 19.5;
            double b = 15.2;
            Delegatechis delegmin = Min;
            Delegatechis delegmax = Max;

            Console.WriteLine($"Минимальное {delegmin(a,b)}");
            Console.WriteLine($"Максимальное {delegmax(a,b)}");

            Console.ReadKey();
        }
    }
}
