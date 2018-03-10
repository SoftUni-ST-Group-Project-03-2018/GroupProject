using System;

namespace Problem_2._Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
			// We receive rectamgle sides (a & b)
            var sideA = double.Parse(Console.ReadLine());
            var sideB = double.Parse(Console.ReadLine());

			// Calculating rectamgle area
            var area = sideA * sideB;

			// Printing rectamgle area with format "$.00"
            Console.WriteLine($"{area:f2}");
        }
    }
}
