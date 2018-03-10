using System;

namespace Problem_5._Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            //  reading the input data from the console
            var name = Console.ReadLine();
            var availableHealth = int.Parse(Console.ReadLine());
            var healthRange = int.Parse(Console.ReadLine());
            var availableEnergy = int.Parse(Console.ReadLine());
            var energyRange = int.Parse(Console.ReadLine());
            // write the output with place holders and new string
            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |{0}{1}|", new string('|', availableHealth), new string('.', healthRange - availableHealth));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', availableEnergy), new string('.', energyRange - availableEnergy));

        }
    }
}
