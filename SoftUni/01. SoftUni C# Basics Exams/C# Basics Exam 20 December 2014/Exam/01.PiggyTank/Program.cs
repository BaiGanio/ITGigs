using System;

class Program
{
    static void Main()
    {
        const int singlePartyBill = 5;
        const int noPartySaveMoney = 2;
        const int inOurCase = 12;
        const int daysInMonth = 30;
        //const int daysInYear = 12 * daysInMonth;
        // 1. Read
        int tankPrice = int.Parse(Console.ReadLine());
        int partyDaysInMonth = int.Parse(Console.ReadLine());
        // 2. Calculate
        //int totalMonthMoneyForParties = partyDaysInMonth * singlePartyBill;
        int daysWithoutParties = daysInMonth - partyDaysInMonth;
        int savedForMonth = daysWithoutParties * noPartySaveMoney;
        int totatlPartyBill = partyDaysInMonth * singlePartyBill;
        double moneyAfterAll = savedForMonth - totatlPartyBill;
        //// 3. Print
        //Console.WriteLine("money for parties: " + totatlPartyBill);
        //Console.WriteLine("money saved for month: " + savedForMonth);
        //Console.WriteLine("after all: {0} - {1} = " + moneyAfterAll, savedForMonth,
        //    totatlPartyBill);
        double monthsNeededForTheTank = (double)tankPrice / moneyAfterAll;
        int result = (int)Math.Ceiling(monthsNeededForTheTank);
        int years = result / inOurCase;
        int months = result % inOurCase;
        if (partyDaysInMonth > 8)
        {
            Console.WriteLine("never");
        }
        else
        {
            Console.WriteLine("{0} years, {1} months", years, months);
        }
    }
}