using System;


namespace PlayGuessNumber
{

    class Program
    {
        public static void Exercise()
        {
            var number = new Random().Next(0, 100);

            Console.WriteLine("Secret is " + number);
            int guess = 0 ;

            do
            {
                Console.Write("Guess the secret number: ");
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess == number)
                    {
                        Console.WriteLine("You won!");
                        return;
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine("The Number that you entered is SMALLER then the target number. Please try again!");
                    }
                    else
                        Console.WriteLine("The Number that you entered is GREATER then the target number. Please try again!");

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                
            } while (guess != number);

            

            Console.WriteLine("You lost!");
        }

        static void Main(string[] args)
        {

            Exercise();
        }
    }
}

