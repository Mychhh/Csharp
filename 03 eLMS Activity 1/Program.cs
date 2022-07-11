using System;

namespace MathApp
{
    public class MathProgram 
    {
        static void Main(string[] args) 
        {
            double x  = 3;

            double power = Math.Pow(x, 2);
            Console.WriteLine(power);
            
            double squareRoot = Math.Sqrt(x);
            Console.WriteLine(squareRoot);

            double y = -4.69;

            double absoluteValue = Math.Abs(y);
            Console.WriteLine(absoluteValue);

            double roundOff = Math.Round(y);
            Console.WriteLine(roundOff);

            double maxx = Math.Max(x, y);
            Console.WriteLine(maxx);

        }
    }
}