using System;

class Program
{
    static void Main()
    {
        try
        {
           
            int numerator = 10;
            int denominator = 0;

            int result = DivideByZeroExample(numerator, denominator);

            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
        }

        Console.ReadLine();
    }

    static int DivideByZeroExample(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        return numerator / denominator;
    }
}

