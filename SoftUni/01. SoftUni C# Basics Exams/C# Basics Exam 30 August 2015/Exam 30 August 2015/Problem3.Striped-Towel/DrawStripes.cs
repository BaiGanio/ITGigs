using System;

namespace Problem3.Striped_Towel
{
    class DrawStripes
    {
        static void Main()
        {
            int towelWidth = int.Parse(Console.ReadLine());
            int towelHeigth = (int)Math.Floor(towelWidth*1.5);

            for (int i = 0; i < towelHeigth; i++)
            {
                // Тест 1.
                //Console.Write(i + " ");
                Console.Write(new string('#', 1));
                Console.Write(new string('.', 2));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', 2));
                Console.WriteLine(new string('#', 1));
            }
        }
    }
}
