using System;
using System.IO; //include the System.IO namespace
namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string writeText = "Hello World!"; //Creates a text string
            File.WriteAllText("filename.txt", writeText); //Create a file and write the content of writeText to it

            string readText = File.ReadAllText("filename.txt"); //Read the contents of the file
            Console.WriteLine(readText); //Output the content
        }
    }
}
