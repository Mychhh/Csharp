using System;

namespace NameSpacePractice
{
    public class Program
    {
        static void Main(string[] args)
        { 
            string name;
            int age;
            bool hasPet;

            Console.Write("What is your name? ");
            name = Console.ReadLine();

            Console.Write("How old are you? ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Do you have a pet? ");
            hasPet = Convert.ToBoolean(Console.ReadLine());

            Person person  = new Person(name, age, hasPet);
            Person person1 = new Person(name);
        }
    }
}