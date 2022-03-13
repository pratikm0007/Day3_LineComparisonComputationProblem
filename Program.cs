using System;

namespace LineComparisonProblem
{
    class Program
    {
        public static double lengthOfLine1;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Co-ordinates value for the Length of Line");
                     
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

        }
    }
}
