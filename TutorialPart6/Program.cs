using System;

namespace TutorialPart6 
{
    public class Challenge
    {
        static void Main(string[] args) 
        {
            string[] email    = new string[5];
            string[] username = new string[5];
            string[] password = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter your Email    : ");
                email[i] = Console.ReadLine();

                Console.Write("Enter your Username : ");
                username[i] = Console.ReadLine();

                Console.Write("Enter your Password : ");
                password[i] = Console.ReadLine();

                Console.WriteLine();
            }

            Console.WriteLine("Please enter the number of your account from 0-4 ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Email    : " + email[num]);
            Console.WriteLine("Username : " + username[num]);
            Console.WriteLine("Password : " + password[num]);
        } 

    }
} 