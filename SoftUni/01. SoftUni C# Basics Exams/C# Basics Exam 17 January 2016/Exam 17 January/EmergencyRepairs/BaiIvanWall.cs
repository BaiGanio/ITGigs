using System;
using System.Text;

namespace EmergencyRepairs
{
    internal class BaiIvanWall
    {
        private static void Main()
        {
            // Input
            ulong number = ulong.MaxValue;
            int emergencyKitsLil = 2;//int.Parse(Console.ReadLine()); // 2
            int numberOfAttacks = 3; //int.Parse(Console.ReadLine()); // 3 => 63 3 24

            //Logic
            // Create the string representation of the number before and after attacks
            string str = ProceedCommands(number, numberOfAttacks);
            Console.WriteLine(str);

            //// Do the rapair :)
            for (int i = str.Length - 1; i >= 1; i--)
            {
               
                emergencyKitsLil--;
            }

            //Console.WriteLine(str);
        }

        
        private static string ProceedCommands(ulong number, int numberOfAttacks)
        {
            string lilString = ConvertToBinary(number);
            //Console.WriteLine(lilString);
            while (numberOfAttacks > 0)
            {
                // Take the shooted position
                int shootedBitPosition = int.Parse(Console.ReadLine());

                // Extract bit at position from the string !! string proceed from left to right and lenght is not zero based!!
                int posInString = lilString.Length - 1 - shootedBitPosition;
                int bitValue = int.Parse(lilString[posInString].ToString());
                //Console.WriteLine("String bit => " + bitValue);

                // check bit at position for 1 and if match change it to 0
                bool isOne = (bitValue & 1) == 1;
                //Console.WriteLine(isOne);
                if (isOne)
                {
                    bitValue = bitValue & 0;
                    //Console.WriteLine("String bit after=> " + bitValue);
                }

                // Add new bit value to the string
                lilString = Replace(lilString, posInString, bitValue);

                //Console.WriteLine(lilString);

                numberOfAttacks--;
            }

            return lilString;
        }
        private static string Replace(string str, int index, int value)
        {
            char[] arr = str.ToCharArray();
            arr[index] = char.Parse(value.ToString());
            str = new string(arr);
            return str;
        }
        private static string ConvertToBinary(ulong value)
        {
            if (value == 0)
            {
                return "0";
            }

            StringBuilder b = new StringBuilder();
            int currentBits = 0;

            while (value != 0)
            {
                b.Insert(0, ((value & 1) == 1) ? '1' : '0');
                value >>= 1;
                currentBits++;
            }
            // By condition ulong is 64 bit valid integer. So we need the leading zeroes :)
            if (currentBits < 64)  
            {
                b.Insert(0, new string('0', 64 - currentBits));
            }

            return b.ToString();
        }

    }
}
