using System;

namespace Tutorial5 
{
    class Program
    {
        static void Main(string[] args) 
        {

            Console.Write("English  : ");
            int englishGrade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Math     : ");
            int mathGrade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Science  : ");
            int scienceGrade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Computer : ");
            int computerGrade = Convert.ToInt32(Console.ReadLine());

            float avg = (englishGrade + mathGrade + scienceGrade + computerGrade) / 4f;

            Console.WriteLine(avg);
        }
    }
}