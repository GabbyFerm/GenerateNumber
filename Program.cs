using System.ComponentModel.Design;

namespace GenerateNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("I have selected a number between 1-100, try to guess it!");


            int guessNumber = Convert.ToInt32(Console.ReadLine());
            int rightNumber = 99;

            while (guessNumber != rightNumber) 
            {
                Console.WriteLine("Enter your guess:");
                guessNumber = Convert.ToInt32(Console.ReadLine());

                if (guessNumber < rightNumber)
                {
                    Console.WriteLine("Too low!");
                    Console.WriteLine("Guess again: ");


                }
                else if (guessNumber > rightNumber)
                {
                    Console.WriteLine("Too high!");
                    Console.WriteLine("Guess again: ");

                }
                else 
                {
                    Console.WriteLine("Your guess is right!!!");
                    break;
                }
                
            }

            
            

            

        }
    }
}
