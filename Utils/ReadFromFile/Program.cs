using System;
using System.Collections;

namespace ReadFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(TrailingZeroes(12));

            int num, baseNum;
            Console.Write("Enter a decimal number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a base: ");
            baseNum = Convert.ToInt32(Console.ReadLine());
            Console.Write(num + " converts to ");
            MulBase(num, baseNum);
            Console.WriteLine(" Base " + baseNum);
            Console.Read();
            //int counter = 0;
            //string line;

            //// Read the file and display it line by line.  
            //System.IO.StreamReader file =
            //    new System.IO.StreamReader(@"E:\GitHub\to-read-from.txt");
            //while ((line = file.ReadLine()) != null)
            //{
            //    System.Console.WriteLine(line);
            //    counter++;
            //}

            //file.Close();
            //System.Console.WriteLine("There were {0} lines.", counter);
            //// Suspend the screen.  
            //System.Console.ReadLine();
        }
        static int TrailingZeroes(int n)
        {
            int cnt = 0;

            while (n > 0)
            {
                n /= 5;
                cnt += n;
            }

            return cnt;
        }

        static void MulBase(int n, int b)
        {
            Stack Digits = new Stack();
            do
            {
                Digits.Push(n % b);
                n /= b;
            } while (n != 0);
            while (Digits.Count > 0)
                Console.Write(Digits.Pop());
        }

    }



}
