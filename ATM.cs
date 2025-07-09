using System;

class Program
{
    static void Main(string[] args)
    {
        double balance = 1000;
        int choice;

        Console.WriteLine("=== Welcome to Simple ATM ===");

        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Current balance: ₹" + balance);
            }
            else if (choice == 2)
            {
                Console.Write("Enter amount to deposit: ₹");
                double deposit = Convert.ToDouble(Console.ReadLine());
                balance += deposit;
                Console.WriteLine("Deposited successfully.");
            }
            else if (choice == 3)
            {
                Console.Write("Enter amount to withdraw: ₹");
                double withdraw = Convert.ToDouble(Console.ReadLine());
                balance -= withdraw;
                Console.WriteLine("Withdrawn successfully.");
            }
            else if (choice == 4)
            {
                Console.WriteLine("Thank you! Exiting...");
            }
        }
        while (choice != 4);
    }
}
