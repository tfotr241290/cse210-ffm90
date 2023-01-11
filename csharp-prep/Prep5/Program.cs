using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        string theName = PromptUserName();
        int theNumber = PromptUserNumber();
        double sqrtNumber = SquareNumber(theNumber);
        DisplayResult(theName,sqrtNumber);

        static void DisplayWelcome(){
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName(){
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber(){
            Console.Write("What is your favorite number? ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static double SquareNumber(int num){
            return Math.Sqrt(num);
        }

        static void DisplayResult(string name, double sqrt){
            Console.WriteLine($"{name}, the square of your number is {sqrt}");
        }

    }
}