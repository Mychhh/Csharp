using System;

namespace DataTypeApp
{

    public class DataTypeProgram 
    {
        static void Main(string[] args) 
        {
            const string NAME = "Michael Pabaya";
            int studentNumber = 35;
            short tuition = 28930;
            sbyte year = 2;
            char section = 'A';

            Console.WriteLine("Student #" + studentNumber + " - " + NAME);
            Console.WriteLine("Section/Year : " + year + section);
            Console.WriteLine("Tuition fee  : " + tuition);
            Console.ReadKey();
        }

    }

}
