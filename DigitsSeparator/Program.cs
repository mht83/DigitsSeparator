using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer between 1 and 99999: ");
        int number = int.Parse(Console.ReadLine());

        DisplayDigits(number);
    }

    static void DisplayDigits(int number)
    {
        int quotient = number / 10;
        int remainder = number % 10;

        if (quotient != 0)
            DisplayDigits(quotient);

        Console.Write($"{remainder}  ");
    }
}
