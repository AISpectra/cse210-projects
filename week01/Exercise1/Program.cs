using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Ask surname
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Print result
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}