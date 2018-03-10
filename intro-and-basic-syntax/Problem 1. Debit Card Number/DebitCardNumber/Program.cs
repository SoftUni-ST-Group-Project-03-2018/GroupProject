//CONFIRMED from kavier
using System;

namespace DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pan number pieces
            int lines = 4;

            // Pan number containts (~>2019 pan numbers contains 4 pieces)
            string pan = "";

            // Read line for every piece of pan number
            while (lines > 0)
            {
                // Read piece of pan number (4 numbers in row)
                int digits = int.Parse(Console.ReadLine());

                // Append pan with received digits with format "$$$$"
                pan += $"{digits:D4} ";

                // Decrease lines that needs to be retrieved
                lines--;
            }

            // Print formated pan
            Console.WriteLine(pan.Trim());
        }
    }
}
