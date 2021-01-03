using System;

namespace BeerStock
{
    internal class ExamHangover
    {
        private static void Main()
        {

            // Input
            int reservedBeers = int.Parse(Console.ReadLine());
            string examOver = "Exam Over";

            // Logic
            int cases = 0;
            int sixpacks = 0;
            int beers = 0;

            string shipment = Console.ReadLine();

            while (shipment != examOver)
            {
                string[] amountType = shipment.Split(' ');
                int amount = int.Parse(amountType[0]);
                string type = amountType[1];

                switch (type)
                {
                    case "beers":
                        beers += amount;
                        break;
                    case "cases":
                        cases += amount;
                        break;
                    case "sixpacks":
                        sixpacks += amount;
                        break;
                    default:
                        Console.WriteLine("You are joking me!");
                        break;
                }

                // Test
                //Console.WriteLine("beers: " + beers);
                //Console.WriteLine("cases: " + cases);
                //Console.WriteLine("sixpacks: " + sixpacks);

                shipment = Console.ReadLine();
            }


            int currentAmountOfBeers =
                    (cases * 24) + (sixpacks * 6) + beers;

            // On every 100 beers one is broken. Don't forget! :)
            int brokenBeers = currentAmountOfBeers/100;
            currentAmountOfBeers = currentAmountOfBeers - brokenBeers;

            if (currentAmountOfBeers < reservedBeers)
            {
                int needMoreBeers = reservedBeers - currentAmountOfBeers;

                int casesNeeded = needMoreBeers/24;
                int casesReminder = needMoreBeers%24;
                int sixpacksNeeded = 0;
                int beersNeeded = 0;

                if (casesReminder >= 6)
                {
                    sixpacksNeeded = casesReminder/6;
                    int sixpacksreminder = casesReminder%6;
                    beersNeeded = sixpacksreminder;
                }
                else
                {
                    beersNeeded = casesReminder;
                }

                // Test
                //Console.WriteLine("Need {0} more beers", needMoreBeers);
                //Console.WriteLine(casesNeeded);

                Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.",
                    casesNeeded, sixpacksNeeded, beersNeeded);
            }
            if (currentAmountOfBeers > reservedBeers)
            {
                int leftOverBeers = currentAmountOfBeers - reservedBeers;

                int casesOver = leftOverBeers/24;
                int casesOverReminder = leftOverBeers%24;
                int sixpacksOver = 0;
                int beersOver;

                if (casesOverReminder >= 6)
                {
                    sixpacksOver = casesOverReminder/6;
                    int sixpacksOverReminder = casesOverReminder%6;
                    beersOver = sixpacksOverReminder;
                }
                else
                {
                    beersOver = casesOverReminder;
                }

                Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.",
                    casesOver, sixpacksOver, beersOver);
            }

        }
    }
}
