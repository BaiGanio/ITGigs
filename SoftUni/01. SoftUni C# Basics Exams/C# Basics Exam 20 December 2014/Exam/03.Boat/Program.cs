

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter some number and I'll draw you a boat! : ");
        // Boat sails width and height 
        int boatSailsWidthAndHeight = int.Parse(Console.ReadLine());
        // Body of the boat = (boatWidthAndHeight – 1) / 2 lines high
        int boatBodyHeight = boatSailsWidthAndHeight / 2;
        // Total boat width
        int totalBoatWidth = boatSailsWidthAndHeight * 2;
        // Sail from the top to the middle and if we reach the middle -> draw sail backward
        int sailAstrixWidth = 1;
        bool sailMiddle = false;
        // Replace astrix from the body with dots
        int bodyasterixReplacer = 0;


        // Draw boat sails
        for (int sailWidth = 0; sailWidth < boatSailsWidthAndHeight; sailWidth++)
        {
            Console.Write(new string('.', boatSailsWidthAndHeight - sailAstrixWidth));
            Console.Write(new string('*', sailAstrixWidth));
            Console.WriteLine(new string('.', totalBoatWidth / 2));
            if (sailMiddle)
            {
                sailAstrixWidth -= 2;
            }
            else
            {
                sailAstrixWidth += 2;
            }
            if (sailAstrixWidth >= boatSailsWidthAndHeight)
            {
                sailMiddle = true;
            }
        }
        // End boat seils
        // Draw boat body
        for (int i = 0; i < boatBodyHeight; i++)
        {
            Console.Write(new string('.', bodyasterixReplacer));
            Console.Write(new string('*', totalBoatWidth));
            Console.WriteLine(new string('.', bodyasterixReplacer));

            bodyasterixReplacer++;
            totalBoatWidth -= 2;
        }
    }
}