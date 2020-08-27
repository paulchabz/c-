using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age  ");
            string ageText = Console.ReadLine();

            //int age = int.Parse(ageText);
            bool isValidAge = int.TryParse(ageText, out int age);

            // if block here 
            if (isValidAge == true)
            {
                age += 20;
                Console.WriteLine($"You are going to be {age} years old in 20 years time :) ");
            }
            else
            {
                Console.WriteLine("That is not a valid age please try again :( ");
            }
           
            //age += 20;

            //Console.WriteLine($"You are going to be {age} in 10 years time");
           // Console.WriteLine($"You are going to be {age} years old in 20 years time :) ");
            Console.ReadLine();

        }
    }
}
