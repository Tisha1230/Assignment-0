using System;

namespace ExceptionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                int[] mylist = { 0, 1, 2, 3, 4 };
                Console.WriteLine(mylist[6]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Not Found");
            }
            finally
            {
                Console.WriteLine("Done!");
            }
        }
    }
}
