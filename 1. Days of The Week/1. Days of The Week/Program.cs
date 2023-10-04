using System;

class Program
{
    static void Main()
    {
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        int dayNumber = int.Parse(Console.ReadLine());

        if (dayNumber >= 1 && dayNumber <= 7)
        {
            string day = days[dayNumber - 1];
            Console.WriteLine(day);
        }
        else
        {
            Console.WriteLine("Invalid day!");
        }
    }
}
