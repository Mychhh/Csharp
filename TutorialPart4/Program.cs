using System;

namespace TutorialPart4 
{
    public class Program 
    {
        static void Main(string[] args) 
        {
            //this is implicit Casting
            int myInt = 10;

            double myDouble = myInt;

            char myChar = 'B';
            int asciiCode = myChar;

            Console.WriteLine(myChar);
            Console.WriteLine(asciiCode);

            //this is explicit Casting
            double grade = 98.99;
            int num = (int)grade;

            int asCode = 66;
            char letter = (char)asCode;

            Console.WriteLine(asCode);
            Console.WriteLine(letter);

            //Conversion Methods
            string x = "5";
            int number = Convert.ToInt32(x);

            Console.WriteLine(x);
            Console.WriteLine(number + 3);

            //Concatenation also known as concatenating ine or more string to another
            string firstName = "Michael";
            string lastName  = "Pabaya";

            Console.WriteLine(firstName +" "+ lastName);
        }
    }
}