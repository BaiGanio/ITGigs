using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArryOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int age = 19;

            if (age > 18)
            {
                int[] someRandomNumbers = PLayNumbersDemo();

                Console.WriteLine("---------------------------------------");

                PrintSmileys(new[] { 22, 69 });
                Console.WriteLine("---------------------------------------");

                PrintSmileys(someRandomNumbers);
            }


            Console.WriteLine("Bye bye");
        }

        static int[] PLayNumbersDemo()
        {
            int[] someRandomNumbers = RandomNumbers(10);

            for (int i = 0; i < someRandomNumbers.Length; i++)
            {
                Console.Write($"someRandomNumber[{i}] have value: [{someRandomNumbers[i]}]");
                if (someRandomNumbers[i] >= 500)
                {
                    someRandomNumbers[i] *= 100;
                    Console.Write($" & have new value  of someRandomNumber[{i}] = [{someRandomNumbers[i]}]");
                }
                Console.WriteLine();
            }
            return someRandomNumbers;
        }
        static void PrintSmileys(int[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine($"Name: {words[i]}  {(char)9786}");
            }
        }
        static int[] RandomNumbers(int someRange)
        {
            int[] numbers = new int[someRange];
            Console.Write("Loading");

            for (int i = 0; i < numbers.Length; i++)
            {
                Random rnd = new Random();
                numbers[i] = rnd.Next(1, 1001);
                //Console.WriteLine(numbers[i]);
                Thread.Sleep(500);
                Console.Write(".");
            }
            Console.WriteLine();

            return numbers;
        }

    }
}
