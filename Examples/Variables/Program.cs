using System;

namespace Variables
{
    class Program
    {
        string Month; //Creating a variable without assigning the value, and assign the value later
                     
        static void Main(string[] args)
        {
            //Create a string variable
            string FirstName = "Tisha ";
            Console.WriteLine(FirstName);

            String LastName = "Shrestha";
            String FullName = FirstName + LastName; //Add a varible to another variable
            Console.WriteLine(FullName); 

            //Create a integer variable
            int Age = 30;
            Console.WriteLine("Age: " + Age); //Combining Text and variable at display

            //Creating a variable without assigning the value, and assign the value later
            string BirthMonth;
            int BirthYear;
            BirthMonth = "June";
            BirthYear = 2020;
            Console.WriteLine($"Born: {BirthMonth} , {BirthYear}");

            //Overwrite an existing variable value
            Age = 1;
            Console.WriteLine($"CorrectedAge:{Age}");

            //Declare many variable of the same type with a comma- separated list
            int first = 1, second = 2, third = 3, fourth = 4, fifth = 5;
            int add = first + second + third + fourth + fifth;
            Console.WriteLine(add);

           
        }
    }
}
