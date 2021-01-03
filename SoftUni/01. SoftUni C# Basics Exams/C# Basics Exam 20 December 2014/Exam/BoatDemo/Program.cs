using System;

namespace BoatDemo
{

    class Program
    {
        static void Main()
        {

            // Input
            int sailWidtHight = 3;
            int boatBody = (sailWidtHight - 1)/2;
            int boatWidth = sailWidtHight*2;

            // Logic
            char asterisk = '*';
            char dot = '.';


            // top sail
            Console.Write(new string(dot, sailWidtHight-1));
            Console.Write(new string(asterisk, 1));
            Console.WriteLine(new string(dot, sailWidtHight));

            int innerSail = (sailWidtHight - 3)/2;
            int innerCounter = 3;

            for (int i = 0; i < innerSail; i++)
            {
                Console.Write(new string(dot, sailWidtHight - innerCounter));
                Console.Write(new string(asterisk, innerCounter));
                Console.WriteLine(new string(dot, sailWidtHight));

                innerCounter += 2;
            }


            // middle sail
            Console.Write(new string(asterisk, sailWidtHight));
            Console.Write(new string(dot, sailWidtHight));
            Console.WriteLine();

            int innerSailDots = 2;
            for (int i = 0; i < innerSail; i++)
            {
                Console.Write(new string(dot, innerSailDots));
                Console.Write(new string(asterisk, sailWidtHight - innerSailDots));
                Console.WriteLine(new string(dot, sailWidtHight));

                innerSailDots += 2;
            }

            // bottom sail
            Console.Write(new string(dot, sailWidtHight - 1));
            Console.Write(new string(asterisk, 1));
            Console.WriteLine(new string(dot, sailWidtHight));


            // body top
            Console.WriteLine(new string(asterisk, boatWidth));

            // body to bottom
            int toBottom = ((sailWidtHight - 1) / 2 ) -1;

            int counter = 1;
            for (int i = 0; i < toBottom; i++)
            {
                Console.Write(new string(dot, counter));
                Console.Write(new string(asterisk,boatWidth - (counter*2)));
                Console.WriteLine(new string(dot, counter));

                counter++;
            }


            Console.WriteLine();



            Console.WriteLine("***********************************************************************");



            char first = 'a';
            char second = 'b';
            int counterMatrixInner = 0;
            int counterMatrixOuter = 0;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    for (int k = 0; k < 9; k++)
                    {
                        for (int l = 0; l < 9; l++)
                        {
                            Console.WriteLine("{0}{1}{2}{3}", i, j, k, l);
                            counterMatrixInner++;
                        }
                    }
                }
            }

            Console.WriteLine(counterMatrixInner);




        }
    }
}
