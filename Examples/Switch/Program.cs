using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOfWeek = 3;
            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Saturday");
                    break;
            }
        }
    }
}
