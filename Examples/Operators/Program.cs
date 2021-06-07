using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Addition operator
            int x = 3;
            int y = 10;
            int sum = x + y;
            Console.WriteLine(sum);

            //Substraction operator
            int z = 200;
            int a = 150;
            int sub = z - a;
            Console.WriteLine(sub);

            //Multiplication operator
            Console.WriteLine(x * z);

            //Division operator
            Console.WriteLine(z / y);

            //Modulus operator : returns division remainder
            Console.WriteLine(z % x);

            //Increment operator : increases the value of variable by 1 
            x++;
            Console.WriteLine(x);

            //Decrement operator: decreases the value of variable by 1
            y--;
            Console.WriteLine(y);

            //addition assignment operator
            a += 2;
            Console.WriteLine(a);

            //Return the highest value
            Console.WriteLine(Math.Max(x, a));

            //Return the lowest value
            Console.WriteLine(Math.Min(x, y));

            //Return square root of x
            Console.WriteLine(Math.Sqrt(y));

            //Return the absolute(positive) value of x
            Console.WriteLine(Math.Abs(-29));

            //Round a number to nearest whole number
            double d = 25.99;
                Console.WriteLine(Math.Round(d));




        }
    }
}
