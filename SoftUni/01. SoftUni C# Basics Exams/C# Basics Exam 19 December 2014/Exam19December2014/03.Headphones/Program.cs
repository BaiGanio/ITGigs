using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Headphones
{
    class Program
    {
        //Your task is to help Stamat write a program that prints his headphones on the console
        //using only asterisks '*' and dashes '-'. And since his headphones are very special
        //they have a diameter. See the example below to better understand how the diameter
        //affects the headphones' size.
        static void Main(string[] args)
        {
            // Input
            //int input = int.Parse(Console.ReadLine());
            int input = 5;
            //Logic
            int totalWidth = (input * 2) + 1;
            int counter = 1;
            //Console.WriteLine(new string('-', totalWidth));

            Console.Write(new string('-', (totalWidth - (input + 2)) / 2));
            Console.Write(new string('*', input + 2));
            Console.WriteLine(new string('-', (totalWidth - (input + 2)) / 2));

            for (int i = 0; i < input - 1; i++)
            {
                Console.Write(new string('-', (totalWidth - (input + 2)) / 2));
                Console.Write("*");
                Console.Write(new string('-', input));
                Console.Write("*");
                Console.WriteLine(new string('-', (totalWidth - (input + 2)) / 2));
            }
            
            for (int i = 0; i < input / 2; i++)
            {
                Console.Write(new string('-', input / 2 - i));
                Console.Write(new string('*', counter));
                Console.Write(new string('-', input / 2 - i));
                Console.Write(new string('-', 1));
                Console.Write(new string('-', input / 2 - i));
                Console.Write(new string('*', counter));
                Console.WriteLine(new string('-', input / 2 - i));
                counter += 2;
            }
            counter = 1;

            Console.Write(new string('*', input));
            Console.Write(new string('-', 1));
            Console.WriteLine(new string('*', input));

            for (int i = input - 1; i > input/2; i--)
            {
                Console.Write(new string('-', counter));
                Console.Write(new string('*', input - (2 * counter)));
                Console.Write(new string('-', counter));
                Console.Write(new string('-', 1));
                Console.Write(new string('-', counter));
                Console.Write(new string('*', input - (2 * counter)));
                Console.WriteLine(new string('-', counter));
                counter ++;
            }
            Console.WriteLine("----------------------------------------------------");
            int stepChange = int.Parse(Console.ReadLine());
            stepChange = (stepChange + 1) % 4;
            Console.WriteLine(stepChange);
        }
        
    }
}
