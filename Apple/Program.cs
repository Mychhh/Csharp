using System;

namespace DataTypeApp 
{
    public class DataTypeProgram 
    {
        static void main(string[] args) 
        {
            Console.Write("Enter the pieces of apple : ");
            sbyte appleNumber;
            appleNumber = Convert.ToSByte(Console.ReadLine());

            Console.Write("Enter total price of " + appleNumber + " apple(s): ");
            float appleTotalPriceF = 0.00f;
            appleTotalPriceF = Single.Parse(Console.ReadLine());

            double appleTotalPriceD; 
            appleTotalPriceF = Convert.ToDouble(appleTotalPriceD);

            Console.WriteLine("The total of " + appleNumber + "apple(s) is : ");
        }
    }
}