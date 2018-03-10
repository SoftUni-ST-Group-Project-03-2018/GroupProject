using System;

namespace DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines  = 4;
            string pan = "";

            while (lines > 0)
            {
                int digits = int.Parse(Console.ReadLine());
                pan += $"{digits:D4} ";

                lines--;
            }

            Console.WriteLine(pan.Trim());
        }
    }
}
