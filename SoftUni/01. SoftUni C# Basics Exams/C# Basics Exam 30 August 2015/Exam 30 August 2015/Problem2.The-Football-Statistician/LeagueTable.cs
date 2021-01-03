using System;
using System.Collections.Generic;

namespace Problem2.The_Football_Statistician
{
    class LeagueTable
    {
        static void Main()
        {
            //Arsenal, Chelsea, Manchester City, Manchester United, Liverpool, Everton, Southampton and Tottenham.
            SortedDictionary<string, int> teamsAndPoints = new SortedDictionary<string, int>();
            teamsAndPoints.Add("Arsenal", 0);
            teamsAndPoints.Add("Chelsea", 0);
            teamsAndPoints.Add("ManchesterCity", 0);
            teamsAndPoints.Add("ManchesterUnited", 0);
            teamsAndPoints.Add("Liverpool", 0);
            teamsAndPoints.Add("Everton", 0);
            teamsAndPoints.Add("Southampton", 0);
            teamsAndPoints.Add("Tottenham", 0);

            //Console.Write("Euro = ");
            decimal paymentForMatchInEuro = decimal.Parse(Console.ReadLine());
            decimal paymentForMatcInBG = paymentForMatchInEuro * 1.94m;

            // Тест 1.
            //Console.WriteLine("In BG = {0} лева", paymentForMatcInBG);

            int matchCounter = 0;
            string end = Console.ReadLine();

            while (end != "End of the league.")
            {
                matchCounter++;

                string[] results = end.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                // Тест 2.
                //Console.WriteLine("---------------------------");
                //foreach (var data in results)
                //{
                //    Console.WriteLine(data);
                //}
                //Console.WriteLine("---------------------------");

                string homeTeam = results[0];
                string awayTeam = results[2];
                string draw = results[1];

                switch (draw)
                {
                    case "X":
                        if (teamsAndPoints.ContainsKey(homeTeam))
                        {
                            teamsAndPoints[homeTeam] += 1;
                        }
                        if (teamsAndPoints.ContainsKey(awayTeam))
                        {
                            teamsAndPoints[awayTeam] += 1;
                        }
                        break;
                    case "1":
                        if (teamsAndPoints.ContainsKey(homeTeam))
                        {
                            teamsAndPoints[homeTeam] += 3;
                        }
                        break;
                    case "2":
                        if (teamsAndPoints.ContainsKey(awayTeam))
                        {
                            teamsAndPoints[awayTeam] += 3;
                        }
                        break;
                }

                end = Console.ReadLine();
            }

            Console.WriteLine();

            // Output
            decimal totalPayment = matchCounter*paymentForMatcInBG;
            Console.WriteLine("{0:F2}lv.", totalPayment);

            // Тест 3.
            //Console.WriteLine("==============================");
            foreach (var team in teamsAndPoints)
            {
                if (team.Key == "ManchesterUnited")
                {
                    Console.WriteLine("Manchester United - {0} points.", team.Value);
                }
                else if (team.Key == "ManchesterCity")
                {
                    Console.WriteLine("Manchester City - {0} points.", team.Value);
                }
                else
                {
                    Console.WriteLine("{0} - {1} points.", team.Key, team.Value);
                }
            }
            //Console.WriteLine("==============================");
        }
    }
}
