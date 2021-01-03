using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Gambling
{
    class Program
    {
        static void Main(string[] args)
        {

            //100
            //2 7 9 A
            //int cash = 100;
            //string input = "2 7 9 A";
            //string[] hand = input.Split(' ');
            decimal cash = decimal.Parse(Console.ReadLine());
            string[] hand = Console.ReadLine().Split(' ');

            int handValue = 0;
            for (int i = 0; i < hand.Length; i++)
            {
                switch (hand[i])
                {
                    case "2":
                        handValue += 2;
                        break;
                    case "3":
                        handValue += 3;
                        break;
                    case "4":
                        handValue += 4;
                        break;
                    case "5":
                        handValue += 5;
                        break;
                    case "6":
                        handValue += 6;
                        break;
                    case "7":
                        handValue += 7;
                        break;
                    case "8":
                        handValue += 8;
                        break;
                    case "9":
                        handValue += 9;
                        break;
                    case "10":
                        handValue += 10;
                        break;
                    case "J":
                        handValue += 11;
                        break;
                    case "Q":
                        handValue += 12;
                        break;
                    case "K":
                        handValue += 13;
                        break;
                    case "A":
                        handValue += 14;
                        break;
                    default:
                        Console.WriteLine("Incorrect input!");
                        break;
                }
            }
            //Console.WriteLine(handValue);
            int testValue = 0;
            int counterLess = 0;
            int counterBigger = 0;
            int counterEqual = 0;

            for (int hand1 = 2; hand1 < 15; hand1++)
            {
                for (int hand2 = 2; hand2 < 15; hand2++)
                {
                    for (int hand3 = 2; hand3 < 15; hand3++)
                    {
                        for (int hand4 = 2; hand4 < 15; hand4++)
                        {
                            testValue = hand1 + hand2 + hand3 + hand4;
                            if (testValue == handValue)
                            {
                                counterEqual++;
                            }
                            if (testValue > handValue)
                            {
                                counterBigger++;
                            }
                            if (testValue < handValue)
                            {
                                counterLess++;
                            }
                        }
                    }
                }
            }
            //Console.WriteLine(counterLess);
            //Console.WriteLine(counterEqual);
            //Console.WriteLine(counterBigger);
            //Console.WriteLine(testValue);
            decimal maxPossibilities = counterLess + counterEqual + counterBigger;
            //Console.WriteLine(maxPossibilities);
            decimal handChance = (counterBigger / maxPossibilities) * 100;
            //Console.WriteLine(handChance);
            decimal expectedWinnings = ((cash * 2) * handChance) / 100;

            if (handChance < 50)
            {
                Console.WriteLine("FOLD");
                Console.WriteLine("{0:F2}", expectedWinnings);
            }
            else
            {
                Console.WriteLine("DRAW");
                Console.WriteLine("{0:F2}", expectedWinnings);
            }

           
        }
    }
}
