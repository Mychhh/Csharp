using System;

namespace ConsoleApp 
{
    public class Program 
    {
        static void Main(string[] args) 
        {

            Console.Write("Enter your name                                : ");
            string name = Console.ReadLine();

            Console.Write("Enter the total number of your enrolled courses: ");
            int courses;
            courses = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the price of your favorite book          : ");
            int book;
            book =  Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Name                     : " + name);
            Console.WriteLine("Total enrolled course    : " + courses);
            Console.WriteLine("Price of my favorite book: " + book);

            Console.Write("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}