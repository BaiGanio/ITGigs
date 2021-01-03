using System;

//•	First Class which accommodates 12 passengers. The ticket price is $7000.
//•	Business Class which accommodates 28 passengers. The ticket price is $3500.
//•	Economy Class which accommodates 50 passengers. The ticket price is $1000.
//•    some passengers are Frequent Flyers and their tickets are 70% off 
//•    some passengers purchase a meal on the flight, which costs 0.5% of the ticket price
//•    for the travel class 
//•     calculate her income and calculate the difference between her income and the
//•     maximum possible income (the maximum possible income being all seats taken,
//•     no Frequent Flyers and everyone purchasing meals).

class AirlineClasses
{
    static void Main()
    {

        //Input
        int firstClassCapacity = 12;
        int firstClassTicket = 7000;
        int bussinesClassCapacity = 28;
        int bussinesClassTicket = 3500;
        int economyClassCapacity = 50;
        int economyClassTicket = 1000;



        //Logic

        //int firstClassMaxProfit = firstClassCapacity + firstClassTicket + (int)mealOnBoard;
        //int bussinesClassMaxProfit = bussinesClassCapacity + bussinesClassTicket + (int)mealOnBoard;
        //int economyClassMaxProfit = economyClassCapacity + economyClassTicket + (int)mealOnBoard;
        double firstClassMaxProfit = firstClassCapacity * firstClassTicket;
        double bussinesClassMaxProfit = bussinesClassCapacity * bussinesClassTicket;
        double economyClassMaxProfit = economyClassCapacity * economyClassTicket;
        double currentFlightIncome = 0;
        double frequentFlyerDiscount = 0;

        for (int i = 0; i < 3; i++)
        {
            int currentClassPassengers = 0;
            int frequentFlyers = 0;
            int meals = 0;

            string[] currentClassValues = Console.ReadLine().Split(' ');
        //    for (int j = 0; j < currentClassValues.Length; j++)
          //  {
                currentClassPassengers = int.Parse(currentClassValues[0]);
                frequentFlyers = int.Parse(currentClassValues[1]);
                meals = int.Parse(currentClassValues[2]);
           // }
                //Console.WriteLine("------------------------------------------");
                //Console.WriteLine("Current class passengers:    {0}",currentClassPassengers);
                //Console.WriteLine("Passangers with discount: {0}", frequentFlyers);
                //Console.WriteLine("Meals: {0}", meals);
                //Console.WriteLine("------------------------------------------");
            double mealOnBoard = 0;
            double currentIncome = 0;
            switch (i)
            {
                case 0:
                    frequentFlyerDiscount =  firstClassTicket * 0.7;
                    mealOnBoard = firstClassTicket * 0.005;

                    currentIncome = ((currentClassPassengers - frequentFlyers) * firstClassTicket) + (frequentFlyers * (firstClassTicket - frequentFlyerDiscount)) + (meals * mealOnBoard);

                    firstClassMaxProfit =  (firstClassCapacity * firstClassTicket) + (firstClassCapacity * mealOnBoard);
                    break;

                case 1:
                    frequentFlyerDiscount =  bussinesClassTicket * 0.7;
                    mealOnBoard = bussinesClassTicket * 0.005;

                    currentIncome = ((currentClassPassengers - frequentFlyers) * bussinesClassTicket) + (frequentFlyers * (bussinesClassTicket - frequentFlyerDiscount)) + (meals * mealOnBoard);

                    bussinesClassMaxProfit = (bussinesClassCapacity * bussinesClassTicket) + (bussinesClassCapacity * mealOnBoard);                   
                    break;

                    case 2:
                    frequentFlyerDiscount =  economyClassTicket * 0.7;
                    mealOnBoard = economyClassTicket * 0.005;

                    currentIncome = ((currentClassPassengers - frequentFlyers) * economyClassTicket) + (frequentFlyers * (economyClassTicket - frequentFlyerDiscount)) + (meals * mealOnBoard);

                    economyClassMaxProfit =(economyClassCapacity * economyClassTicket) + (economyClassCapacity * mealOnBoard);                   
                    break;

                default:
                    Console.WriteLine("Wrong data!");
                    break;
            }
            //Console.WriteLine("Current class income: {0}", currentIncome);
            currentFlightIncome += currentIncome;

        }

        //Console.WriteLine("-------------------------------------------");
        //Console.WriteLine(firstClassMaxProfit);
        //Console.WriteLine(bussinesClassMaxProfit);
        //Console.WriteLine(economyClassMaxProfit);
        //Console.WriteLine("-------------------------------------------");
        
        //Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("{0}", (int)currentFlightIncome);

        double maxFlightProfit = firstClassMaxProfit + bussinesClassMaxProfit + economyClassMaxProfit;
        
        //Console.WriteLine("--------------------------------------------------------------");
        //Console.WriteLine("Max flight profit can be: {0}", maxFlightProfit);
        //Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine("{0}", (int)Math.Ceiling(maxFlightProfit - currentFlightIncome));
    }
}
