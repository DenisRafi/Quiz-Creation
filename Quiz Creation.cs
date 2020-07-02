using System;

namespace ByDenisRafi
{
    class CA
    {
        public static void CurrentQuestion(string correctAnswer)
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Please Enter Answer: ");
                string userAnswer = Console.ReadLine();

                if ((userAnswer != "Hello World!"))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nError - Not a Valid Input");
                }
                else
                {
                    if (userAnswer == correctAnswer)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nThat is Correct!");
                        break;
                    }
                    else if (userAnswer != correctAnswer)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\nSorry, that is incorrect");
                        break;
                    }
                }
            } while (true);
        }
        static void Main()
        {
            Console.Title = "Quiz Creation";
            string correctAnswer = "Hello World!";
            CurrentQuestion(correctAnswer);
            Console.ReadLine();
        }
    }
}
