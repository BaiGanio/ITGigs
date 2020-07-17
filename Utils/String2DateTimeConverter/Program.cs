using System;

namespace String2DateTimeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = "01/08/2008";
            StringToDateTime(date);
            DateTimeToString();
        }

        private static void StringToDateTime(string date)
        {
            DateTime dt = Convert.ToDateTime(date);
            Console.WriteLine(dt);
        }

        private static void DateTimeToString()
        {
            DateTime dt =DateTime.Now;
            Console.WriteLine(dt.ToShortDateString());
        }
    }
}
