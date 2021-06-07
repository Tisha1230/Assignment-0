using System;

namespace User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?"); //type the name and press enter

            string name = Console.ReadLine(); //gets use input fron keyboard and stores it in string variable name
            Console.WriteLine($"My name is {name}."); //prints the value of the input variable 
            Console.WriteLine();


            //user input text and numbers
            Console.WriteLine("What is you age?");

            int age = Convert.ToInt32(Console.ReadLine()); //Converts input string to int
            Console.WriteLine($"I am {age} years old.");
        }
    }
}
