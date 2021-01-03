using System;
using System.Collections.Generic;
using System.Linq;



class Program
{
    static IEnumerable<string> Split(string str, int chunkSize)
    {
        return Enumerable.Range(0, str.Length / chunkSize)
            .Select(i => str.Substring(i * chunkSize, chunkSize));
    }
    static void Main()
    {
        // Input from 2 lines
        string text = Console.ReadLine();
        int lineWidth = int.Parse(Console.ReadLine());
        string bombedColumns = Console.ReadLine();

        int rows = (text.Length / 10) + 1;
        int cols = lineWidth;
        int sheetCheetElements = rows * cols;

        string[] bombList = bombedColumns.Split(' ');
        string currentLine = "";
        string checkLine = " ";
        int currentIndex = 0;
        bool hit = false;



        if (text.Length < sheetCheetElements)
        {
            text = text + new string(' ', sheetCheetElements - text.Length);
        }


        for (int j = 0; j < text.Length; j += lineWidth)
        {
            if (j + lineWidth > text.Length)
            {
                lineWidth = text.Length - j;
            }
            currentLine = text.Substring(j, lineWidth);
            for (int index = 0; index < currentLine.Length; index++)
            {
                for (int bomb = 0; bomb < bombList.Length; bomb++)
                {
                    if (currentLine[index] == int.Parse(bombList[bomb]))
                    {`
                        currentLine[index] += "*";
                    }
                    Console.Write("{0}", currentLine);
                }
                Console.WriteLine();
            }
        }
    }
}