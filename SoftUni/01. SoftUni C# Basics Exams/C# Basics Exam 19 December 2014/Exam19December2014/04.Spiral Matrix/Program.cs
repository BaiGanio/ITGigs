using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Spiral_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            string text = "SoftUni";
            //int n = int.Parse(Console.ReadLine());
            //string text = Console.ReadLine();

            //Logic
            char[,] matrix = new char[n, n];
            FillMatrix(matrix, text);
            PrintMatrix(matrix, n);
        }
        private static void PrintMatrix(char[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrix(char[,] matrix, string text)
        {

            int row = 0;
            int col = 0;
            int maxRotation = text.Length * text.Length;
            int textCurrentIndex = 0;
            int currentSteps = 0;
            int stepsCounter = matrix.GetLength(0); // One step for each direction
            int stepChange = 0;// stepsCounter decrement with 1 each 2 times
            int direction = 0;// for right, 1 for down, 2 for left, 3 for up

            for (int i = 0; i <= maxRotation; i++)
            {
                matrix[row, col] = text[textCurrentIndex];

                if (textCurrentIndex > text.Length)
                {
                    textCurrentIndex = 0;
                }
                //Console.Write(textCurrentIndex);
                if (currentSteps <= stepsCounter)
                {
                    currentSteps++;
                }
               if (currentSteps == stepsCounter)
               {
                   stepChange = (stepChange + 1) % 4;
                   if (stepChange == 3)
                   {
                       stepsCounter--;
                   }
                   direction = (direction + 1) % 4;
                   currentSteps = 0;
               }
                    switch (direction)
                    {
                        case 0:
                            Console.Write("->");
                            col++;
                            break;
                        case 1:
                            Console.Write("V");
                            row++;
                            break;
                        case 2:
                            Console.Write("<-");
                            col--;
                            break;
                        case 3:
                            Console.Write("^");
                            row--;
                            break;
                        default:
                            break;
                    }
                    //Console.WriteLine();
                textCurrentIndex++;
            }


        }

    }
}

