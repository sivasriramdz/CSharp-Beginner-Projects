using System;

class Program
{
    static void Main(string[] args)
    {
        int totalBill = 0;
        int choice = -1;

        Console.WriteLine("=== Grocery Billing System ===");

        while (choice != 0)
        {
            Console.WriteLine("\nItems Available:");
            Console.WriteLine("1. Rice  - ₹50 per kg");
            Console.WriteLine("2. Sugar - ₹40 per kg");
            Console.WriteLine("3. Oil   - ₹100 per litre");
            Console.WriteLine("0. Exit and Print Bill");

            Console.Write("\nEnter item number (0-3): ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 0)
            {
                break;
            }

            Console.Write("Enter quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());

            int price = 0;

            if (choice == 1)
                price = 50;
            else if (choice == 2)
                price = 40;
            else if (choice == 3)
                price = 100;
            else
            {
                Console.WriteLine("Invalid item. Please choose 1–3.");
                continue;
            }

            int itemTotal = price * qty;
            totalBill += itemTotal;

            Console.WriteLine("Item added! Subtotal: ₹" + itemTotal);
        }

        Console.WriteLine("\n----- Final Bill -----");
        Console.WriteLine("Total Amount: ₹" + totalBill);
        Console.WriteLine("Thank you for shopping!");
    }
}
