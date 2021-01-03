using System;

//•	Input: 
//•	The string "leap" for leap year or "normal" for year that is not leap.
//•	The number c – number of months Bob signs contracts in the year.
//•	The number f – number of months that Bob spends with his family

namespace _01.TravellerBob
{
    class Program
    {
        static void Main()
        {
            /*
             * Bob loves travelling by plane
             * Thankfully, his job of being a businessman involves traveling a couple of times during the month.
             * Bob is a busy man. He has months when he uses his private jet in order to go and sign new contracts.
             * In a contract month, he travels 3 times per week. Although Bob loves his work, he also cares about his family.
             * He spends family months, when he has 1 less travel per week than a contract month and he travels only 2 weeks.
             * The other months are considered "normal" during which Bob travels 2/5 less than during contract months.
             * In addition, if the year is leap, Bob travels 5% more overall. Assume that a month has exactly 4 weeks. 
             * Your task is to write a program that calculates how many times Bob travels around the world during
             *  the year (rounded down to the nearest integer number).
             *  
             *  •	The string "leap" for leap year or "normal" for year that is not leap.
             *  •	The number c – number of months Bob signs contracts in the year.
             *  •	The number f – number of months that Bob spends with his family.
             *  
             */

            // Input
            string leapOrNormal = Console.ReadLine();
            int contractMonths = int.Parse(Console.ReadLine());
            int familyMonths = int.Parse(Console.ReadLine());

            // Logic
            int totalContractMonthTravels = contractMonths * 4 * 3;
            int totalFamilyMonthsTravels = familyMonths * 2 * 2;
            int regularMonths = 12 - (contractMonths + familyMonths);
            double totalRegularMonthTravels = ((double)regularMonths * 12) * 3 / 5;
            double totalTravels;
            double handy;
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine(totalContractMonthTravels);
            Console.WriteLine(totalFamilyMonthsTravels);
            Console.WriteLine(regularMonths);
            Console.WriteLine(totalRegularMonthTravels);
            Console.WriteLine("-------------------------------------------------------------------------------");

            switch (leapOrNormal)
            {
                case "leap":
                    handy = (totalRegularMonthTravels + totalFamilyMonthsTravels + totalContractMonthTravels) * 5 / 100;
                    totalTravels = (totalRegularMonthTravels + totalFamilyMonthsTravels + totalContractMonthTravels) + handy;
                    Console.WriteLine("{0}", (int)totalTravels);
                    break;
                //case "normal":
                //    totalTravels = (totalRegularMonthTravels + totalFamilyMonthsTravels + totalContractMonthTravels);
                //    Console.WriteLine("{0}", (int)totalTravels);
                //    break;
                default:
                    totalTravels = (totalRegularMonthTravels + totalFamilyMonthsTravels + totalContractMonthTravels);
                    Console.WriteLine("{0}", (int)totalTravels);
                    //Console.WriteLine("No nothing!");
                    break;
            }
        }
    }
}
