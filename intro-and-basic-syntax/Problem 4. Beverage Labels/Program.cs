//CONFIRMED from kavier
using System;

namespace Problem_4._Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            // Getting params for fizzy drink
            string drink = Console.ReadLine();
            int volumePer100ml = int.Parse(Console.ReadLine());
            int energyPer100ml = int.Parse(Console.ReadLine());
            int sugarPer100ml = int.Parse(Console.ReadLine());

            // Calculating energy and sugar
            double totalEnergy = (double)volumePer100ml * energyPer100ml / 100;
            double totalSugar = (double)volumePer100ml * sugarPer100ml / 100;

            //Printing each on new line
            Console.WriteLine($"{volumePer100ml}ml {drink}:\r\n{totalEnergy}kcal, {totalSugar}g sugars");
        }
    }
}
