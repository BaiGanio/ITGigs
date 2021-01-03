using System;

namespace Problem4.Teleport_Points
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            string testOutput1 = String.Format("X = {0}; Y = {1}", this.X, this.Y);
            return testOutput1.ToString();
        }
    }

    class DeadpoolValidTeleportPoints
    {
        //1.	[X Y] – coordinates for point A
        //2.	[X Y] – coordinates for point  B
        //3.	[X Y] – coordinates for point C
        //4.	[X Y] – coordinates for point  D
        //5.	R – Radius
        //6.	H – Step

        static void Main()
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();
            string line3 = Console.ReadLine();
            string line4 = Console.ReadLine();
            string radius = Console.ReadLine();
            string step = Console.ReadLine();
            //string testOutput1 = String.Format("X = {0}; Y = {1}", coordinates[0], coordinates[1]);
            //Console.WriteLine(testOutput1);

            Point pointA = CreatePoint(line1);
            Point pointB = CreatePoint(line2);
            Point pointC = CreatePoint(line3);
            Point pointD = CreatePoint(line4);

            double wide = CalculateDistanceBetweenPoints(pointA, pointB);
            Console.WriteLine(wide);
        }

        private static double CalculateDistanceBetweenPoints(Point pointA, Point pointB)
        {
            double roomWide = 0;
            if (pointA.X < 0)
            {
             roomWide = -(pointA.X) + pointB.X;
            }
           
            return roomWide;
        }

        private static Point CreatePoint(string line)
        {
            string[] coordinates = line.Split(' ');
            double x = double.Parse(coordinates[0]);
            double y = double.Parse(coordinates[1]);
            Point point = new Point(x, y);
            return point;
        }

    }
}
