using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Age Calculator ===");

        Console.Write("Enter your birth year: ");
        int birthYear = Convert.ToInt32(Console.ReadLine());

        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;

        Console.WriteLine("You are " + age + " years old.");

        if (age < 13)
            Console.WriteLine("You are a child.");
        else if (age < 20)
            Console.WriteLine("You are a teenager.");
        else if (age < 60)
            Console.WriteLine("You are an adult.");
        else
            Console.WriteLine("You are a senior citizen.");
    }
}
