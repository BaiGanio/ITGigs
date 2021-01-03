using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysToApplyAtSoftUni
{
    class Program
    {
        //Write a program that reads from the console the name of the user and prints a message, 
        //notifying him how many days he has left for application for the spring semester at Software University.
        //The days should be printed in binary representation of the number. 
        // 1st January 2015
        //28th April 2015
        //"{name}, you have only {binaryDays} days to apply for the spring semester at Software University!".

        static void Main(string[] args)
        {
            // Input
            string nameOfTheUser = Console.ReadLine();
            //string nameOfTheUser = "Johny Boy";

            //string magicString = "------------------------------------";

            // Logic
            DateTime exam = new DateTime(2015, 4, 28);
            DateTime pastDate = new DateTime(2015, 1, 1);
            double daysUntilExam = exam.Subtract(pastDate).TotalDays;
            int toBase = 2;
            string binaryDays = Convert.ToString((int)daysUntilExam, toBase);

            //Console.WriteLine(magicString);

            //Console.WriteLine("Today date: {0}",today);
            //Console.WriteLine("Exam date: {0}", exam);
            Console.WriteLine("Days until exam: {0}", daysUntilExam);


            //Console.WriteLine(magicString);

            Console.WriteLine("{0}, you have only {1} days to apply for the spring" +
            "semester at Software University!", nameOfTheUser, binaryDays);

            //Console.WriteLine(magicString);
        }


    }
}
