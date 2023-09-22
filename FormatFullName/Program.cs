using System;

class Program
{
    static string FormatFullName(string firstName, string lastName)
    {
        string formattedName = $"{lastName}, {firstName}";
        return formattedName;
    }

    static void Main()
    {
        Console.WriteLine("Please enter your first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Please enter your last name: ");
        string lastName = Console.ReadLine();

        string formattedFullName = FormatFullName(firstName, lastName);
        Console.WriteLine($"Formatted Name: {formattedFullName}");
    }
}

