using  System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[] input = Console.ReadLine().ToCharArray();
        //Console.WriteLine("=========================================");
//        Console.WriteLine(n);
//        Console.WriteLine(input);
        char[,] chessBoard = new char[n, n];
        int currentIndex = 0;

        for (int row = 0; row < chessBoard.GetLength(0); row++)
        {
            for (int col = 0; col < chessBoard.GetLength(1); col++)
            {
                if (currentIndex  >= input.Length)
                {
                    currentIndex = 0;
                }
                else
                {
                    chessBoard[row, col] = input[currentIndex];
                }
                currentIndex++;
            }
        }

        char currentChar;
        int whiteSum = 0;
        int blackSum = 0;

//        for (int i = 0; i < chessBoard.GetLength(0); i++)
//        {
//            for (int j = 0; j < chessBoard.GetLength(1); j++)
//            {
//                currentChar = chessBoard[i, j];
//
//                if ((currentChar >= 'a' && currentChar <= 'z')
//                    || 
//                    (currentChar >= 'A' && currentChar <= 'Z')
//                    || 
//                    (currentChar >= '0' && currentChar <= '9'))
//                {
//                    Console.Write("{0,4} ", (int)currentChar);
//                }
//                else
//                {
//                    Console.Write("{0,4} ", '0');
//                }
//            }
//            Console.WriteLine();
//        }

        for (int i = 0; i < chessBoard.GetLength(0); i++)
        {
            for (int j = 0; j < chessBoard.GetLength(1); j++)
            {
                currentChar = chessBoard[i, j];
                if (i % 2 == 0 && char.IsUpper(currentChar))
                {
                    whiteSum += currentChar;
                }
                else if (i % 2 == 0 && char.IsLetterOrDigit(currentChar))
                {
                    blackSum += currentChar;
                }
                else if (i % 2 == 0 && char.IsUpper(currentChar))
                {
                    blackSum += currentChar;
                }
                else if (i % 2 ==0 && char.IsLetterOrDigit(currentChar))
                {
                    whiteSum += currentChar;
                }
            }
        }

        if (whiteSum == blackSum)
        {
            Console.WriteLine("Equal result: {0}", blackSum);
        }
        else
        {
            Console.WriteLine("The winner is: {0} team", whiteSum > blackSum ? "white" : "black");

            int differenceInResult = Math.Abs(whiteSum - blackSum);
            Console.WriteLine(differenceInResult);


        }


    }
}
