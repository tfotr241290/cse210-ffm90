using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions first = new Fractions(5);
        Console.WriteLine(first.GetFractionString());
        Console.WriteLine(first.GetDecimalValue());

        Fractions second = new Fractions(1,4);
        Console.WriteLine(second.GetFractionString());
        Console.WriteLine(second.GetDecimalValue());

        Fractions third = new Fractions(3,8);
        Console.WriteLine(third.GetFractionString());
        Console.WriteLine(third.GetDecimalValue());


    }
}