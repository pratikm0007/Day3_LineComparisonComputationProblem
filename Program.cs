using System;
namespace LineComparisonProblem
{
    class Program
    {
        public static double lengthOfLine1;
        public static double lengthOfLine2;
        /// <summary>
        /// compare length of two line.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Co-ordinates value for the Length of Lines");

            //Calculation for line1 length
            Console.WriteLine("Enter value for 1st Line point1 isX1 ");
            double isX1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value for 1st Line point1 isY1 ");
            double isY1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value for 1st Line point2 isX2 ");
            double isX2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value for 1st Line point2 isY2 ");
            double isY2 = Convert.ToDouble(Console.ReadLine());

            lengthOfLine1 = Math.Sqrt((Math.Pow((isX2 - isX1), 2)) + (Math.Pow((isY2 - isY1), 2)));
            Console.WriteLine($"Length of line1 is : {lengthOfLine1}");

            //Calculation for line2 length
            Console.WriteLine("Enter value for 2nd Line point1 isX11 ");
            double isX11 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value for 2nd Line point1 isY11 ");
            double isY11 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value for 2nd Line point2 isX22 ");
            double isX22 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value for 2nd Line point2 isY22 ");
            double isY22 = Convert.ToDouble(Console.ReadLine());

            lengthOfLine2 = Math.Sqrt((Math.Pow((isX22 - isX11), 2)) + (Math.Pow((isY22 - isY11), 2)));
            Console.WriteLine($"Length of line2 is : {lengthOfLine2}");

            //To check two line are equal or not.
            Console.Write("Result Of Equality Check : ");
            Console.WriteLine(lengthOfLine1.Equals(lengthOfLine2));

            //Compare two line at end point.
            Console.Write("Compared Result : ");
            Console.WriteLine(lengthOfLine1.CompareTo(lengthOfLine2));

            if (lengthOfLine1.CompareTo(lengthOfLine2) == 1)
            {
                Console.WriteLine($"Length of line1: {lengthOfLine1} is greater than Length of line2: {lengthOfLine2}");
            }
            else if (lengthOfLine1.CompareTo(lengthOfLine2) == -1)
            {
                Console.WriteLine($"Length of line1: {lengthOfLine1} is less than Length of line2: {lengthOfLine2}");
            }
            else
            {
                Console.WriteLine($"Length of line1: {lengthOfLine1} is equal to Length of line2: {lengthOfLine2}");
            }

        }
    }
}
