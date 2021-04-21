using System;
using System.Globalization;

namespace Decimals
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = double.Parse("2.987", NumberStyles.Currency, CultureInfo.GetCultureInfo("de-DE"));
         //   string output = s.ToString("N", CultureInfo.GetCultureInfo("de-DE"));
            Console.WriteLine(s);
            //Console.WriteLine(output);
        }
    }
}
