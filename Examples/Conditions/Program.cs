using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string MyScore = Console.ReadLine(); //Takes score input in string
            int score = Convert.ToInt32(MyScore); //converts string to integer

            //Using if..else if...else statements
            if (score >= 80)
            {
                Console.WriteLine("Excellent! You have outstanding score.");
            }
            else if (score >= 60 && score < 80)
            {
                Console.WriteLine("Good Job! You have done well!");
            }
            else
            {
                Console.WriteLine("Try one more time! Your score is low.");
            }
        }
    }
}
