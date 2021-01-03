using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RockLq
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());
            int totalWidth = input * 3;
            int someLength = input;
            int hands = input;
            int torse = input;
            int lowerDressPart = input;
            int handsLength = (input / 2) - 2;
            int underArm = 1;


            Console.Write(new string('.', totalWidth / 3));
            Console.Write(new string('*', input));
            Console.WriteLine(new string('.', totalWidth / 3));

            for (int i = 0; i < input / 2; i++)
            {
                Console.Write(new string('.', hands - 2));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', (totalWidth - ((hands - 2) * 2)) - 2));
                Console.Write(new string('*', 1));
                Console.WriteLine(new string('.', hands - 2));
                hands -= 2;
                torse += 3;
            }
           torse = input;

            Console.Write(new string('*', 1));
            Console.Write(new string('.', input - 2));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', input));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', input - 2));
            Console.WriteLine(new string('*', 1));

            

            if (handsLength > 0)
            {
                for (int i = 0; i < handsLength; i++)
                {
                    Console.Write(new string('*', 1));
                    Console.Write(new string('.', someLength - 4));
                    Console.Write(new string('*', 1));

                    Console.Write(new string('.', underArm));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('.', input));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('.', underArm));

                    Console.Write(new string('*', 1));
                    Console.Write(new string('.', someLength - 4));
                    Console.WriteLine(new string('*', 1));
                    underArm += 2;
                    someLength -= 2;
                }
            }


            //Console.WriteLine("-------------------------------");

            Console.Write(new string('*', 1));
            Console.Write(new string('.', 1));

            Console.Write(new string('*', 1));
            Console.Write(new string('.', input - 4));
            Console.Write(new string('*', 1));

            Console.Write(new string('.', input));

            Console.Write(new string('*', 1));
            Console.Write(new string('.', input - 4));
            Console.Write(new string('*', 1));

            Console.Write(new string('.', 1));
            Console.WriteLine(new string('*', 1));



            //Console.WriteLine("-------------------------------");

            for (int i = 0; i < input - 1; i++)
            {
                Console.Write(new string('.', lowerDressPart - 1));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', torse));
                Console.Write(new string('*', 1));
                Console.WriteLine(new string('.', lowerDressPart - 1));
                torse += 2;
                lowerDressPart -= 1;
            }

            Console.WriteLine(new string('*', totalWidth));



        }
    }
}
