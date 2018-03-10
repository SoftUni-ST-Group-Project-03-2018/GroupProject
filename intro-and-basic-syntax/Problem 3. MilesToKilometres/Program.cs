using System;

namespace MilesToKilometres
{
    class Program
    {
        static void Main(string[] args)
        {
            //We recieve from the Console the distance in miles -> an integer; 
            double a = double.Parse(Console.ReadLine());

            //We calculate the distance from miles to kilometers using the formula 1 mile = 1.60934 km
            double km = a * 1.60934;

            //The Console is printing our result formatted to the 2nd character after the decimal point
            Console.WriteLine($"{km:f2}");
        }
    }
}
