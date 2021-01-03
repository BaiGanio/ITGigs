using System;

class Program
{
    static void Main()
    {
        int numberOfLines = int.Parse(Console.ReadLine());
        char gems = char.Parse(Console.ReadLine());
        //string gems = Console.ReadLine();
        int counter = 1;
        int outerLine = numberOfLines/2;
        for (int i = 0; i < numberOfLines / 2; i++)
        {
            Console.Write(new string('-', outerLine));
            Console.Write(new string(gems, counter));
            Console.WriteLine(new string('-', outerLine));
            counter += 2;
            outerLine -= 1;
        }
        counter = 0;
        outerLine = 1;
        Console.WriteLine(new string(gems, numberOfLines));

        for (int i = (numberOfLines / 2) - 1; i >= 0; i--)
        {
            Console.Write(new string('-', outerLine));
            Console.Write(new string(gems, numberOfLines - 2));
            Console.WriteLine(new string('-', outerLine));
            outerLine += 1;
            numberOfLines -= 2;

        }

    }
}
