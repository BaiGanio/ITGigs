using System;
using System.Numerics;

namespace PetarsGame
{
    class Program
    {
        static void Main()
        {
            ulong startNumber = ulong.Parse(Console.ReadLine());
            ulong endNumber = ulong.Parse(Console.ReadLine());
            string replacementString = Console.ReadLine();

            BigInteger sum = 0;

            for (ulong current = startNumber; current < endNumber; current++)
            {
                if (current % 5 == 0)
                {
                    sum += current;
                }
                else
                {
                    sum += current % 5;
                }
            }

            string sumAsString = sum.ToString();

            string digitForReplace;

            if (sum % 2 == 0)
            {
                digitForReplace = sumAsString[0].ToString();
            }
            else
            {
                digitForReplace = sumAsString[sumAsString.Length - 1].ToString();
            }

            //Console.WriteLine(sum);
            //Console.WriteLine(digitForReplace);

            string output = sumAsString.Replace(digitForReplace, replacementString);
            Console.WriteLine(output);

        }
    }
}
