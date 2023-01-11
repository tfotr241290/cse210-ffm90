using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;
        List<int> numbers = new List<int>();

        while (number != 0){
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine()); 
            if (number != 0){
                numbers.Add(number);
            }
            
        }
        int total = numbers.Sum();
        double average = numbers.Average();
        Console.WriteLine($"The total sum is: {total}");
        int count = numbers.Count();
        float av = ((float)total) / count;
        Console.WriteLine($"The average is: {av}");
        int maxNumber = numbers.Max();
        Console.WriteLine($"The largest number is {maxNumber}");


    }
}