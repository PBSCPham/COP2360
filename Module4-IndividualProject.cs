using System;

class StringDivider
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input the first number:");
        string Input1 = Console.ReadLine();

        Console.WriteLine("Please input the second number:");
        string Input2 = Console.ReadLine();

        try
        {
            int Integer1 = Convert.ToInt32(Input1);
            int Integer2 = Convert.ToInt32(Input2);

            int Quotient = Divide(Integer1, Integer2);
            Console.WriteLine($"The quotient of {Integer1} divided by {Integer2} is equal to {Quotient}.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: At least one input is not a valid integer.");
            Console.WriteLine($"Detailed error message: {ex.message}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Unable to divide by zero.");
            Console.WriteLine($"Detailed error message: {ex.message}");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Error: At least one input is too great a number.");
            Console.WriteLine($"Detailed error message: {ex.message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: An unexpected error has occured.");
            Console.WriteLine($"Detailed error message: {ex.message}");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
    static int Divide(int a, int b)
    {
        return a / b;
    }
    
}
