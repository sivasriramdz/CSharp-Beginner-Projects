using System;

class Employee
{
    public string Name;
    public int ID;
    public double Salary;

    public Employee(string name, int id, double salary)
    {
        Name = name;
        ID = id;
        Salary = salary;
    }

    public double CalculateBonus()
    {
        return Salary * 0.10;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("\nEmployee Details:");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + ID);
        Console.WriteLine("Salary: ₹" + Salary);
        Console.WriteLine("Bonus: ₹" + CalculateBonus());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Employee ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Employee emp = new Employee(name, id, salary);
        emp.DisplayInfo();
    }
}
