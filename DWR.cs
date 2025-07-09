using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Daily Work Report Generator ===\n");

        Console.Write("Enter number of employees: ");
        int n = Convert.ToInt32(Console.ReadLine());

        string[] names = new string[n];
        string[] tasks = new string[n];
        double[] hours = new double[n];
        string[] status = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nEmployee #{i + 1}");

            Console.Write("Name: ");
            names[i] = Console.ReadLine();

            Console.Write("Task Description: ");
            tasks[i] = Console.ReadLine();

            Console.Write("Hours Worked: ");
            hours[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Task Status (Pending / In Progress / Completed): ");
            status[i] = Console.ReadLine();
        }

        Console.WriteLine("\n--- Daily Work Summary ---");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n{names[i]}'s Report:");
            Console.WriteLine($"Task: {tasks[i]}");
            Console.WriteLine($"Hours Worked: {hours[i]}");
            Console.WriteLine($"Status: {status[i]}");
        }

        Console.WriteLine("\n✅ All reports logged successfully.");
    }
}
