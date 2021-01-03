using System;

namespace _02.Numerology
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] inputValues = Console.ReadLine().Split(' ');
            string input = "01.01.1914 g0g0";
            string[] inputValues = input.Split(' ');
            string date = inputValues[0];
            string name = inputValues[1];
            string[] dataValues = inputValues[0].Split('.');

            string upperCaseAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowerCaseAlphabet = "abcdefghijklmnopqrstuvwxyz";

            int nameValue = 0;
            long totalSum = 0;
            bool isOdd = false;

            //Console.WriteLine("---------------------------------------------------------");
            //Console.WriteLine(date);
            //Console.WriteLine(name);
            //Console.WriteLine("---------------------------------------------------------");

            // Take multiplication of the date
            long currentMultiplication = 1;
            foreach (var item in dataValues)
            {
                if ((int.Parse(item) % 2) == 1)
                {
                    isOdd = true;
                }
                currentMultiplication = currentMultiplication * int.Parse(item);
                //Console.WriteLine( item);
            }

            if (isOdd)
            {
                currentMultiplication = currentMultiplication * currentMultiplication;
            }

            //Console.WriteLine("---------------------------------------------------------");

            //Console.WriteLine("Date multiplication: {0}", currentMultiplication);
            Console.WriteLine("{0}", currentMultiplication);

            Console.WriteLine("---------------------------------------------------------");


            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < upperCaseAlphabet.Length; j++)
                {
                    if (name[i] == upperCaseAlphabet[j])
                    {
                        nameValue += (j + 1) * 2;
                    }
                }
            }
            Console.WriteLine(nameValue);

            Console.WriteLine("---------------------------------------------------------");
            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < lowerCaseAlphabet.Length; j++)
                {
                    if (name[i] == lowerCaseAlphabet[j])
                    {
                        nameValue += j + 1;
                    }
                }
            }
            Console.WriteLine(nameValue);

            Console.WriteLine("---------------------------------------------------------");

            totalSum = nameValue + currentMultiplication;
            Console.WriteLine(totalSum);

            Console.WriteLine("---------------------------------------------------------");
            string toto = totalSum.ToString();
            //int lolo = 0;
            int[] celestials = new int[toto.Length];
            for (int i = 0; i < toto.Length; i++)
            {
                Console.WriteLine(toto[i]);
                int lolo = int.Parse(toto[i].ToString());
                Console.WriteLine(lolo);
            }
            Console.WriteLine(toto);

        }
    }
}
