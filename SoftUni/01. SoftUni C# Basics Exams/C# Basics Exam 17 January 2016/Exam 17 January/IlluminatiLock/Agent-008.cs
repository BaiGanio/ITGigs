using System;

namespace IlluminatiLock
{
    internal class Agent008
    {
        private static void Main(string[] args)
        {
            int illuminatiNumber = int.Parse(Console.ReadLine());
            int width = 3 * illuminatiNumber;
            int height = 1 + illuminatiNumber;


            //up of the eye
            Console.Write(new string('.', illuminatiNumber));
            Console.Write(new string('#', illuminatiNumber));
            Console.WriteLine(new string('.', illuminatiNumber));

            // middle of the eye upper part
            // how much loops we need => hardcored lines: 4, total height: illuminatiNumber + 1, total = 6/ 2 parst

            int loopsPerSide = (height - 4)/2;
            int innerDots = 0;

            for (int i = 0; i < loopsPerSide; i++)
            {
                Console.Write(new string('.', (illuminatiNumber - 2) - innerDots));
                Console.Write(new string('#', 2));
                Console.Write(new string('.', innerDots));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', (illuminatiNumber - 2)));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', innerDots));
                Console.Write(new string('#', 2));
                Console.WriteLine(new string('.', (illuminatiNumber - 2) - innerDots));

                innerDots += 2;
            }

            Console.Write(new string('.', 1));
            Console.Write(new string('#', 2));
            Console.Write(new string('.', illuminatiNumber - 3));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', illuminatiNumber - 2));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', illuminatiNumber - 3));
            Console.Write(new string('#', 2));
            Console.WriteLine(new string('.', 1));



            // middle of the eye lower part
            Console.Write(new string('.', 1));
            Console.Write(new string('#', 2));
            Console.Write(new string('.', illuminatiNumber - 3));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', illuminatiNumber - 2));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', illuminatiNumber - 3));
            Console.Write(new string('#', 2));
            Console.WriteLine(new string('.', 1));

            int outerDots = 3;

            for (int i = 0; i < loopsPerSide; i++)
            {
                Console.Write(new string('.', outerDots));
                Console.Write(new string('#', 2));
                Console.Write(new string('.', (illuminatiNumber - outerDots) -2));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', illuminatiNumber - 2));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', (illuminatiNumber - outerDots) - 2));
                Console.Write(new string('#', 2));
                Console.WriteLine(new string('.', outerDots));

                outerDots += 2;
            }



            // down of the eye
            Console.Write(new string('.', illuminatiNumber));
            Console.Write(new string('#', illuminatiNumber));
            Console.WriteLine(new string('.', illuminatiNumber));




        }
    }
}
