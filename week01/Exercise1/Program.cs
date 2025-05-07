using System;

class Program
{
    static void Main()
    {
        // prompt for first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // prompt for last name
        Console.Write("What is your last name? "); 
        string lastName = Console.ReadLine();

        // display the formatted name
        Console.WriteLine($"\nYour name is {lastName}, {firstName}.");
    }
}