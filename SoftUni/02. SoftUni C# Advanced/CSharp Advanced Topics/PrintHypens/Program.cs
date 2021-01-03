using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintHypens
{
    class Program
    {
        static void Main()
        {
            //for (int i = 0; i <= 10; i++)
            //{
            //    PrintHyphens(i);
            //}

            DateTime today = DateTime.Now;
            Console.WriteLine("Today is: " + today);
            DateTime tomorrow = today.AddDays(-100);
            Console.WriteLine("Tomorrow is: " + tomorrow);
        }

        static void PrintHyphens(int count)
        {
            Console.WriteLine(
                new string('-', count));
        }
    }

}
