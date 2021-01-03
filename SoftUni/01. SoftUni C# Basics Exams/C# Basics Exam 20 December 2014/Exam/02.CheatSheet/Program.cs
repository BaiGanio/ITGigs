using System;

class Program
{
    static void Main()
    {
       
        // Cheet Sheet table
        int numberOfRows = int.Parse(Console.ReadLine());
        int numberOfColumns = int.Parse(Console.ReadLine());
        // Cheet Sheet vertical and horizontal start numbers
        long verticalSartNumber = int.Parse(Console.ReadLine());
        long horizontalStartNumber = int.Parse(Console.ReadLine());
        // Cheet Sheet box value
        long currentTableBoxSum = 0;
        long currentHorizontalNumber = horizontalStartNumber;
        // Cheet Sheet print format
        string currentSumToString = "";

        // Cheet Sheet rows iteration
        for (int cheetSheetRow = 0; cheetSheetRow < numberOfRows; cheetSheetRow++)
        {
            int currentRow = cheetSheetRow;
            //  Cheet Sheet column iterations
            for (int cheetSheetCol = 0; cheetSheetCol < numberOfColumns; cheetSheetCol++)
            {
                int currentCol = cheetSheetCol;
                // Cheet Sheet box value
                currentTableBoxSum = verticalSartNumber * currentHorizontalNumber;

                // Cheet Sheet print format
                currentSumToString = Convert.ToString(currentTableBoxSum);
                //currentSumToString = currentSumToString.Trim();
                Console.Write("Cheet Sheet[{0}, {1}] ==> row = [{3}] and col = [{4}] have values ==>  = {2} ",
                    currentRow,
                    currentCol,
                    currentSumToString,
                    verticalSartNumber,
                    currentHorizontalNumber);

                // Temporary changed values
                currentTableBoxSum = 0;
                currentHorizontalNumber++;
                Console.WriteLine();
            }

            // Cheet Sheet vertical and horizontal start numbers
            currentHorizontalNumber = horizontalStartNumber;
            verticalSartNumber++;
            Console.WriteLine();
        }
    }
}
