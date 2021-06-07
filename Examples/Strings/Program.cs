using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello World!"; //Create a string
            Console.WriteLine(greeting);

            int length = greeting.Length; //Find the length of string
            Console.WriteLine(length);

            string upper = greeting.ToUpper(); //Convert string to UPPER CASE
            Console.WriteLine(upper);

            Console.WriteLine(greeting.ToLower()); //Convert string to lower case

            //String concatenation: combining two strings
            string name = "Mazda ";
            string model = "CX9 ";
            string CarName = name + model;
            Console.WriteLine(CarName);

            Console.WriteLine(string.Concat(name, model, greeting)); //with concat() method

            //String Interpolation: substitutes value of variable into placeholders
            Console.WriteLine($"Car Name: {CarName}");

            Console.WriteLine(greeting[0]); //access characters in a string by referring to its index number

            //Find the index position of a specific character in a string 
            int charPos = greeting.IndexOf("W");
            Console.WriteLine(charPos);

            string lastWord = greeting.Substring(charPos); //Substring: extracts characters from a string starting from specified character position/index
            Console.WriteLine(lastWord);

            string dquotes = "You are the \"Apple\" of my eye!"; //using "" in a string
            string squotes = "Are you \'OK\'?"; //using '' in a string
            string backsl = "Use \\ here."; //using \ in a string
            Console.WriteLine();
            Console.WriteLine(dquotes);
            Console.WriteLine(squotes);
            Console.WriteLine(backsl);
            Console.WriteLine();

            //find out if the expression is true or false
            int ten = 10;
            int eight = 8;
            Console.WriteLine(ten > eight);
            Console.WriteLine(eight == 08);




        }
    }
}
