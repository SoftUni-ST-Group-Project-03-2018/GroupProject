using System;

namespace MilesToKilometres
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double km = a * 1.60934;
            Console.WriteLine($"{km:f2}");
        }
    }
}
