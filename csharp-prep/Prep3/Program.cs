using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int rNumber = randomNumber.Next(1,100);
        Console.WriteLine("Welcome to Guess My Number game");
        Console.WriteLine("Guess the number from 1 to 100");
        
        int guess = 0;
        
        while (guess != rNumber){
            guess = int.Parse(Console.ReadLine());

            if (guess < rNumber){
                Console.WriteLine("The number is higher than this, Try it again!");
            }
            else if (guess > rNumber){
                Console.WriteLine("Tue number is lower than this, Try it again!");
            }
            else {
                Console.WriteLine("Correct! You guessed my number");
            }
            
        }
    }
}