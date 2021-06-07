using System;

namespace Loops
{
    class Program
    {
        public static void whileloop()
        {
            //using while loop
            int TestNum1 = 5;
            while (TestNum1 <= 10)
            {
                Console.WriteLine(TestNum1);
                TestNum1++;
            }
        }

        public static void doWhileloop()
        {

            //using do..while loop
            int TestNum2 = 10;
            do
            {
                Console.WriteLine(TestNum2);
                TestNum2--;
            }
            while (TestNum2 >= 5);

            Console.WriteLine();
        }
        public static void forloop()
        {
            //using for loop
            string KeyWord = "Welcome!";
            for (int length = KeyWord.Length; length < 10; length++)

            {
                Console.WriteLine(KeyWord);

            }

        }

        public static void foreachloop() 
        {
            //using foreach loop
            string[] name = { "Joey", "Phoebe", "Chandler", "Ross", "Racheal", "Monica" };
            foreach (string i in name)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //Using break and continue.
            //break if the name Ross found

            foreach (string i in name)
            {
                if ( i == "Ross")
                {
                    break;
                }
                Console.WriteLine(i);
                
            }
            Console.WriteLine();

            //Continue if Ross found
            foreach (string i in name)
            {
                if (i == "Ross")
                {
                    continue;
                }
                Console.WriteLine(i);
            }
                       
        }
        static void Main(string[] args)
        {
            whileloop();
            doWhileloop();
            forloop();
            foreachloop();

            

        }
    }
}
