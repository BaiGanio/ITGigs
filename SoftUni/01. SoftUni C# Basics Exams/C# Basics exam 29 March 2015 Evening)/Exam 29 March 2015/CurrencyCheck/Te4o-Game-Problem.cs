using System;

namespace CurrencyCheck
{
    class Te4oGameProblem
    {
        static void Main()
        {
            // 2600 rubles is 2600 / 100 = 26 * 3.5 = 91 leva, 
            // 60 dollars is 60 * 1.5 = 90 leva , 
            // 60 euro is 60 * 1.95 = 117 leva, 
            // 130 leva for 2 games is 130 / 2 = 65 leva per game,
            // 70 leva is 70 leva. 
            // The cheapest game is 65 leva.

            decimal rubles = decimal.Parse(Console.ReadLine());
            decimal dollars = decimal.Parse(Console.ReadLine());
            decimal euro = decimal.Parse(Console.ReadLine());
            decimal levaFor2Copies = decimal.Parse(Console.ReadLine());
            decimal levaFor1Copie = decimal.Parse(Console.ReadLine());

           Console.WriteLine("=======================================");

            decimal rublesInLevaForCopy = (rubles / 100) * (decimal)3.5;
            decimal dollarsInLevaForCopy = dollars * (decimal)1.5;
            decimal eurosInLevaForCopy = euro * (decimal)1.95;

            decimal promoPriceForCopy = levaFor2Copies/2;

            if (promoPriceForCopy < levaFor1Copie && promoPriceForCopy < rublesInLevaForCopy && promoPriceForCopy < dollarsInLevaForCopy && promoPriceForCopy < eurosInLevaForCopy)
            {
                Console.WriteLine("{0:x2}", promoPriceForCopy);
            }
            if (levaFor1Copie < promoPriceForCopy && levaFor1Copie < rublesInLevaForCopy && levaFor1Copie < dollarsInLevaForCopy && levaFor1Copie < eurosInLevaForCopy)
            {
                Console.WriteLine("{0:x2}", promoPriceForCopy);
            }
            if (rublesInLevaForCopy < promoPriceForCopy && rublesInLevaForCopy < levaFor1Copie && rublesInLevaForCopy < dollarsInLevaForCopy && rublesInLevaForCopy < eurosInLevaForCopy)
            {
                Console.WriteLine("{0:x2}", rublesInLevaForCopy);
            }
            if (dollarsInLevaForCopy < promoPriceForCopy && dollarsInLevaForCopy < levaFor1Copie && dollarsInLevaForCopy < rublesInLevaForCopy && dollarsInLevaForCopy < eurosInLevaForCopy)
            {
                Console.WriteLine("{0:x2}", dollarsInLevaForCopy);
            }
            if (eurosInLevaForCopy < promoPriceForCopy && eurosInLevaForCopy < levaFor1Copie && eurosInLevaForCopy < rublesInLevaForCopy && eurosInLevaForCopy < dollarsInLevaForCopy)
            {
                Console.WriteLine("{0:x2}",eurosInLevaForCopy);
            }
        }
    }
}
