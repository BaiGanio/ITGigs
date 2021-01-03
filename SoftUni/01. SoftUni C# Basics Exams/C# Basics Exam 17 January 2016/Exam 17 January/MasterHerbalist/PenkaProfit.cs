using System;

namespace MasterHerbalist
{
    internal class PenkaProfit
    {
        private static void Main()
        {

            // Input
            decimal dailyExpenses = decimal.Parse(Console.ReadLine());//250;
            decimal averageEarnings = 0;
            int workDays = 0;
            string gameOver = "Season Over";



            // Logic

            string currentInfo = Console.ReadLine();
            decimal currentDayEarnings = 0;

            while (currentInfo != gameOver)
            {
                // Extract variables we need to calculate over
                string[] info = currentInfo.Split(' ');
                int hours = int.Parse(info[0]);
                string path = info[1];
                decimal price = decimal.Parse(info[2]);

                // Traverse the path and collect the herbs
                int currentHerbal = 0;
                int herbalFound = 0;
                int pathLength = path.Length;
                for (int i = 0; i < hours; i++)
                {
                    if (currentHerbal >= pathLength)
                    {
                        currentHerbal = 0;
                    }
                    if (path[currentHerbal].Equals('H'))
                    {
                        herbalFound++;
                    }
                    //Console.WriteLine(path[currentHerbal]);
                    //Console.WriteLine(currentHerbal);

                    currentHerbal++;
                }

                currentDayEarnings += herbalFound * price;

                //Console.WriteLine(herbalFound);

                workDays++;
                currentInfo = Console.ReadLine();
            }


            averageEarnings = currentDayEarnings/workDays;

            decimal extraMoney = 0;

            if (averageEarnings >= dailyExpenses)
            {
                extraMoney = averageEarnings - dailyExpenses;
                Console.WriteLine("Times are good. Extra money per day: {0:f2}.", extraMoney);
            }
            else
            {
                extraMoney = dailyExpenses - averageEarnings;
                Console.WriteLine("We are in red. Extra money needed: {0}", Math.Round(extraMoney));
            }
            
        }
    }
}
