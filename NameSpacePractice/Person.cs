using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpacePractice
{
    public class Person
    {
        public string name;
        public int    age;
        public bool   hasPet;

        public Person(string name, int age, bool hasPet)
        {
            string petOwner = "";

            this.name   = name; 
            this.age    = age; 
            this.hasPet = hasPet;

            petOwner = (hasPet) ? "I am a pet owner" : "I am not a pet owner";

            Console.WriteLine("Hello i am " + petOwner + " My name is " + name + " I am " + age + " years old");
        }

        public Person(string name)
        {
            this.name = name;

            Console.WriteLine("My name is " + name);
        }
    }
}
