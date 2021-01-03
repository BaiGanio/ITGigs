using System;

namespace CakeTycoon
{
    internal class IvanchosProfit
    {
        private static void Main()
        {
            // Input
            ulong wantedCakes = ulong.Parse(Console.ReadLine());
            decimal kilosFlourForOneCake = int.Parse(Console.ReadLine());
            int availableKilosOfFlour = int.Parse(Console.ReadLine());
            int availableTruffels = int.Parse(Console.ReadLine());
            decimal truffelPrice = decimal.Parse(Console.ReadLine());

            // Logic
            decimal totaltruffelCosts = truffelPrice*availableTruffels;
            decimal numberOfCakesPerDay = availableKilosOfFlour / kilosFlourForOneCake;
            decimal pricePerCake = (totaltruffelCosts / wantedCakes) * (decimal)1.25;
            

            //Console.WriteLine("Total truffels price: {0}", truffelPrice);
            //Console.WriteLine("Number of cakes per day => {0}", Math.Floor(numberOfCakesPerDay));
            //Console.WriteLine("Price per cake: {0}", decimal.Round(pricePerCake,2));


            // Output
            if (numberOfCakesPerDay >= wantedCakes)
            {
                Console.WriteLine("All products available, price of a cake: {0}", decimal.Round(pricePerCake, 2));
            }

            if (numberOfCakesPerDay < wantedCakes)
            {
                numberOfCakesPerDay = Math.Floor(numberOfCakesPerDay);
                decimal neededKilosOfFlour = (wantedCakes * kilosFlourForOneCake) - availableKilosOfFlour;
               // Console.WriteLine("total flour => " + wantedCakes * kilosFlourForOneCake);

                Console.WriteLine("Can make only {0} cakes, need {1} kg more flour", numberOfCakesPerDay, decimal.Round(neededKilosOfFlour, 2));
            }


        }
    }
}
