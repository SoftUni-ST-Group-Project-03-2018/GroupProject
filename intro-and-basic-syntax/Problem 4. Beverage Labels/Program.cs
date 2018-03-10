using System;

namespace Problem_4._Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
			//Getting params for fizzy drink
            string beverage = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());
			
			//Calculating energy and sugar
            double allEnergy = (double)volume * energy / 100;
            double allSugar = (double)volume * sugar / 100;
			
			//Printing each on new line
            Console.WriteLine($"{volume}ml {beverage}:\r\n{allEnergy}kcal, {allSugar}g sugars");
        }
    }
}
