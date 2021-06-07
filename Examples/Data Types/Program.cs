using System;

namespace Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 5; // int type : 32-bit(4 bytes) signed integer 
            Console.WriteLine(myInt);

            long myLong = 150000000009999L; //long type: 64-bit(8 bytes) signed integer
            Console.WriteLine(myLong);

            float myFloat = 10.25f; //float type: 32-bit(4 Bytes). Stores fractional numbers- 6 to 7 decimal digits
            Console.WriteLine(myFloat);

            double myDouble = 19.99999d; //double type: 64-bit(8 Bytes). Stores fractional numbers - 15 decimal digits
            Console.WriteLine(myDouble);

            bool myBool = true; //bool type- 1 bit. Stores true or false values
            Console.WriteLine(myBool);

            char myChar = 'P'; //char type: 16-bit(2 Bytes). Stores a single character/letter, surrounde by single quotes
            Console.WriteLine(myChar);

            string myString = "Hello World!"; //string type: 2 bytes per character. stores a sequence of characters, surroumded by double quotes
            Console.WriteLine(myString);
            Console.WriteLine();


            //Implicit casting: done automatically, while converting smaller type size to larger type size
            int myNum = 10;
            double myDoubleNum = myNum;
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(myNum);
            Console.WriteLine();

            //Explicit casting: done manually, by placing the type in parentheses in front of the value
            double myDoubleNum1 = 10.99d;
            int myNum1 = (int)myDoubleNum1;
            Console.WriteLine(myNum1);
            Console.WriteLine(myDoubleNum1);
            Console.WriteLine();

            //Type conversion methods
            Console.WriteLine(Convert.ToString(myNum)); //int to string
            Console.WriteLine(Convert.ToDouble(myInt)); //int to double
            Console.WriteLine(Convert.ToInt32(myDouble)); //double to int
            Console.WriteLine(Convert.ToInt16(myChar)); //char to int. output is 80!?
            Console.WriteLine(Convert.ToString(myBool)); //bool to string
            Console.WriteLine(Convert.ToBoolean(0)); //specified int to boolean value. '0' is false. tested: any other numbers outputs true.
            Console.WriteLine(Convert.ToBoolean(myNum));


          
        }
    }
}
