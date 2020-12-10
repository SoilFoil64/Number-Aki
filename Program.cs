using System;

namespace Number_Aki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Number Aki, think of a number BETWEEN 0 AND 100 and I will try to guess it.");
            Console.WriteLine("Press any key to begin");
            Console.ReadKey();
            Console.Clear();
            string q = "Is your number ";
            //---------------------------------------QUESTION 1
            Console.WriteLine("Let us begin...");
            Console.WriteLine(q + "more than 37? (y/n)");
            string q1 = Console.ReadLine();
            if (q1 == "y") 
            {
                // ----------------------------------QUESTION 2
                // next question should ask for more than 37
                Console.Clear();
                Console.WriteLine(q + "less than 64? (y/n)");
                string q2 = Console.ReadLine();
                if (q2 == "y")
                {
                    guessnum:
                    Random random = new Random();
                    int guess = random.Next(0, 64);
                    Console.WriteLine(q + guess + "? (y/n)");
                    string yna = Console.ReadLine();
                    if (yna == "y")
                    {
                        Console.WriteLine("Yay! I guessed it!");
                        Console.WriteLine("Press any key to exit...");
                        Console.ReadKey();
                        Environment.Exit(1);
                    }
                    if (yna == "n") { goto guessnum; }
                }
                else if (q2 == "n")
                {
                    guessnum:
                    Random random = new Random();
                    int guess = random.Next(64, 100);
                    Console.WriteLine(q + guess + "? (y/n)");
                    string yna = Console.ReadLine();
                    if (yna == "y")
                    {
                        Console.WriteLine("Yay! I guessed it!");
                        Console.WriteLine("Press any key to exit...");
                        Console.ReadKey();
                        Environment.Exit(1);
                    }
                    if (yna == "n") { goto guessnum; }
                }
            }
            else if (q1 == "n") 
            {
                //----------------------------------QUESTION 2
                // next question should ask for less than 37
                Console.Clear();
                Console.WriteLine(q + "more than 15? (y/n)");
                string q2 = Console.ReadLine();
                if (q2 == "y")
                {
                    guessnum:
                    Random random = new Random();
                    int guess = random.Next(15, 37);
                    Console.WriteLine(q + guess + "? (y/n)");
                    string yna = Console.ReadLine();
                    if (yna == "y") 
                    {
                        Console.WriteLine("Yay! I guessed it");
                        Console.WriteLine("Press any key to exit...");
                        Console.ReadKey();
                        Environment.Exit(1);
                    }
                    if (yna == "n") { goto guessnum;}
                }
                else if (q2 == "n")
                {
                    guessnum:
                    Random random = new Random();
                    int guess = random.Next(0, 15);
                    Console.WriteLine(q + guess + "? (y/n)");
                    string yna = Console.ReadLine();
                    if (yna == "y")
                    {
                        Console.WriteLine("Yay! I guessed it!");
                        Console.WriteLine("Press any key to exit...");
                        Console.ReadKey();
                        Environment.Exit(1);
                    }
                    if (yna == "n") { goto guessnum; }
                }
            }
        }
    }
}
