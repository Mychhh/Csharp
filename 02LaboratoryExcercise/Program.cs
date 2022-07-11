using System;

namespace LabExcercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the pieces of apple       : ");
            int applePieces = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter total price of " + applePieces + " apple(s) : ");
            float appleTotalPrice = Convert.ToSingle(Console.ReadLine());

            //implicit casting
            double originalPrice = appleTotalPrice;

            //explicit casting
            int convertedPrice = (int)appleTotalPrice;

            Console.WriteLine("\nThe total price of " + applePieces + " apple(s)                   : " + originalPrice);
            Console.WriteLine("The value of original price is                  : " + originalPrice);
            Console.WriteLine("The value of converted price is                 : " + convertedPrice);
        }
    }
}