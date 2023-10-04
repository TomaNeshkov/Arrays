using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numberStrings = input.Split(' ');
        int sum = 0;

        foreach (string numberString in numberStrings)
        {
            int number = int.Parse(numberString);

            if (number % 2 == 0)
            {
                sum += number;
            }
        }

        Console.WriteLine(sum);
    }
}
