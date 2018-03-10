using System;

namespace Problem_5._Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            //  reading the input data from the console
            string character = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            // write the output with place holders and new string
            Console.WriteLine($"Name: {character}");
            Console.WriteLine("Health: |{0}{1}|", new string('|', currentHealth), new string('.', maxHealth - currentHealth));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', currentEnergy), new string('.', maxEnergy - currentEnergy));

        }
    }
}
