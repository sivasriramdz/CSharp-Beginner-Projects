using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Student Marksheet Generator ===\n");

        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        Console.Write("Enter mark 1: ");
        int mark1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter mark 2: ");
        int mark2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter mark 3: ");
        int mark3 = Convert.ToInt32(Console.ReadLine());

        int total = mark1 + mark2 + mark3;
        double average = total / 3.0;

        string grade = "";

        if (average >= 90)
            grade = "A";
        else if (average >= 75)
            grade = "B";
        else if (average >= 60)
            grade = "C";
        else if (average >= 40)
            grade = "D";
        else
            grade = "F";

        Console.WriteLine("\n----- Result -----");
        Console.WriteLine("Name   : " + name);
        Console.WriteLine("Total  : " + total);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Grade  : " + grade);
    }
}
