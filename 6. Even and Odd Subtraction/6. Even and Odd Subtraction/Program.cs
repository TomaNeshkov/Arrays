using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numberStrings = input.Split(' ');
        int sumEven = 0;
        int sumOdd = 0;

        foreach (string numberString in numberStrings)
        {
            int number = int.Parse(numberString);
            if (number % 2 == 0)
            {
                sumEven += number;
            }
            else
            {
                sumOdd += number;
            }
        }

        int difference = sumEven - sumOdd;
        Console.WriteLine(difference);
    }
}
