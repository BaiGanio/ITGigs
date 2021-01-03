using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02.SpyHard
{
 //     INPUT
//•	The first input line holds a number (the key).
//•	The second input line holds a string (the message).
    class Program
    {
        static void Main(string[] args)
        {
//The key will be a number, it shows the base of the numeral system you’ll need to use
//for decryption. The message is comprised of various symbols which you convert to
//a number by adding together either the letter’s position in the alphabet 
//(a = 1, b = 2, … , z = 26) if the symbol is a letter, or the symbol’s code in the ASCII table
//otherwise. After you get the sum of the symbols, you need to convert it to the numeral 
//system provided by the key.

            // INPUT
            int key = int.Parse(Console.ReadLine());
            //Console.Write("[{0}]", key);                            // <-------- First digit from the output
            string message = Console.ReadLine();
            //Console.Write("[{0}]", message.Length);      // <-------- Second digit from the output
            // LOGIC
            // Use BigInteger to hold the factorial wich
            //will be the base of the secret Numeral Sustem
            int currentSum = 0;
            foreach (char character in message)
            {
                if (character < 'a' || character < 'z')
                {
                    Console.WriteLine(character);
                }
            }
            BigInteger numeralSystem = 1;
            message = message.ToLower();
            Console.WriteLine("-----------------------------------");
            //Console.WriteLine(asciiSum);
            Console.WriteLine("-----------------------------------");
            //Console.WriteLine(asciiSum.ToString().Length);
            Console.WriteLine("-----------------------------------");
            //Console.WriteLine(currentSum);
            Console.WriteLine("-----------------------------------");
            
        }
    }
}
