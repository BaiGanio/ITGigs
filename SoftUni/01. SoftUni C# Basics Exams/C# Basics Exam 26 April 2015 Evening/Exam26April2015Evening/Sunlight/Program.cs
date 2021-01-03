using System;

namespace Sunlight
{
    class Program
    {
        static void Main()
        {
            // Input
            Console.Write("Enter some number and I'll draw you a sun! : ");
            int sizeOfTheSun = int.Parse(Console.ReadLine());

            // Logic
            int width = sizeOfTheSun * 3;

            Console.Write(new string('.', width / 2));
            Console.Write(new string('*', 1));
            Console.WriteLine(new string('.', width / 2));

            int counter = 0;
            for (int i = 0; i < sizeOfTheSun - 1; i++)
            {
                Console.Write(new string('.', counter + 1));
                Console.Write(new string('*', 1));

                Console.Write(new string('.', ((width / 2 - 2)) - counter));

                Console.Write(new string('*', 1));

                Console.Write(new string('.', ((width / 2 - 2)) - counter));

                Console.Write(new string('*', 1));
                Console.WriteLine(new string('.', counter + 1));

                counter++;
            }

            for (int i = 0; i < sizeOfTheSun / 2; i++)
            {
                Console.Write(new string('.', sizeOfTheSun));
                Console.Write(new string('*', sizeOfTheSun));
                Console.WriteLine(new string('.', sizeOfTheSun));
            }

            Console.WriteLine(new string('*', width));

            for (int i = 0; i < sizeOfTheSun / 2; i++)
            {
                Console.Write(new string('.', sizeOfTheSun));
                Console.Write(new string('*', sizeOfTheSun));
                Console.WriteLine(new string('.', sizeOfTheSun));
            }

            counter = 1;
            for (int i = 0; i < sizeOfTheSun - 1; i++)
            {
                Console.Write(new string('.', sizeOfTheSun - counter));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', (sizeOfTheSun / 2) + i));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', (sizeOfTheSun / 2) + i));
                Console.Write(new string('*', 1));
                Console.WriteLine(new string('.', sizeOfTheSun - counter));

                counter++;
            }

            Console.Write(new string('.', width / 2));
            Console.Write(new string('*', 1));
            Console.WriteLine(new string('.', width / 2));

        }
    }
}
