using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] stringsArray = input.Split(' ');
        Array.Reverse(stringsArray);

        foreach (string str in stringsArray)
        {
            Console.Write(str + " ");
        }
    }
}
