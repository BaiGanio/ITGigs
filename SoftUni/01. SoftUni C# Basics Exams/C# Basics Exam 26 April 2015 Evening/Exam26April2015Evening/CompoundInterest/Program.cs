using System;

namespace CompoundInterest
{
    class Program
    {
        static void Main()
        {
            // Input
            decimal tvPrice = decimal.Parse(Console.ReadLine());
            int leasingInYears = int.Parse(Console.ReadLine());
            decimal bankYearInterest = decimal.Parse(Console.ReadLine());
            decimal friednInterest = decimal.Parse(Console.ReadLine());

            // Logic
            decimal bank =  MoneyForTheBank(tvPrice, bankYearInterest, leasingInYears);
            //MoneyForTheBank(tvPrice, bankYearInterest, leasingInYears);
           decimal friend =  MoneyForTheFriend(tvPrice, friednInterest);
            //Console.WriteLine(friend);

           if (bank > friend)
           {
               Console.WriteLine("{0:0.00} Friend", friend);
           }
           else
           {
               Console.WriteLine("{0:0.00} Bank", bank);
           }
            
        }

         static decimal MoneyForTheFriend(decimal tvPrice, decimal friednInterest)
        {
            // 'FV = PV * (1 + i) '. Where 'FV' (future value) is the money owed at the end of the period. 'PV' (present value) is the money you want to withdraw today, 'i' is the interest rate. 

            decimal futureValue = 0;

             futureValue = tvPrice * (1 + friednInterest);

             return futureValue;
        }

        static decimal  MoneyForTheBank(decimal tvPrice, decimal bankYearInterest, int leasingInYears)
        {
            // 'FV = PV * (1 + i)n '. Where 'FV' (future value) is the money owed at the end of the period. 'PV' (present value) is the money you want to withdraw today, 'i' is the interest rate and 'n' is the term of the loan. 

            decimal futureValue = 0;

            //futureValue = (decimal) (tvPrice * Math.Pow( (double) (1 + bankYearInterest), leasingInYears)); 
            futureValue = tvPrice * (decimal)Math.Pow((double)(1 + bankYearInterest), leasingInYears);
            return futureValue;


        }
    }
}