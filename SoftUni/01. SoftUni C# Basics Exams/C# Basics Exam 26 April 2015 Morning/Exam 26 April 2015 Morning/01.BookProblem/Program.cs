using System;
// ReSharper disable All

namespace _01.BookProblem
{
    class Program
    {
        // Provisio <=> Requirement
        // 1. Month => 30 days;
        //    Year => 12 months;
        //    Round to upper => 3.1 months = 4
        // 2. Output => "X years Y days"; If never => "never"
        static void Main()
        {
            // Input
            //250000
            //5
            //10
            int totalBookPages = int.Parse(Console.ReadLine());
            int campingDaysInMonth = int.Parse(Console.ReadLine());
            int normalDayPages = int.Parse(Console.ReadLine());

            // Logic
            int daysInMonth = 30;
            int monthsInYear = 12;
            double daysToReadTheBook = 0;
            double monthsToReadTheBook;
            double totalTimeInYears;
            int totalMonths;



            int daysForReading = daysInMonth - campingDaysInMonth;
            int pagesForMonth = daysForReading * normalDayPages;
            daysToReadTheBook = totalBookPages / normalDayPages;
            //Console.WriteLine("=================================>>>>>>>>>>>>");

            if (campingDaysInMonth == daysInMonth)
            {
                Console.WriteLine("never");
            }
            else if (daysToReadTheBook <= daysInMonth)
            {
                
                monthsToReadTheBook = daysToReadTheBook / (monthsInYear * daysInMonth);
                Console.WriteLine("{0} years 1 months", (int)monthsToReadTheBook);
            }
            else
            {
                monthsToReadTheBook = totalBookPages / pagesForMonth;
                totalTimeInYears = monthsToReadTheBook / monthsInYear;
                totalMonths = (int)monthsToReadTheBook % monthsInYear;

                Console.WriteLine("{0} years {1} months", (int)totalTimeInYears, totalMonths);
            }
            //Console.WriteLine("=================================>>>>>>>>>>>>");

        }
    }
}
