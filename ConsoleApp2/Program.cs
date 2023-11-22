using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public User(int userId, string name, string email)
        {
            UserId = userId;
            Name = name;
            Email = email;
        }
    }

    class Payment
    {
        public int PaymentId { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime PaymentDate { get; set; }

        public Payment(int paymentId, int userId, decimal amount, string description, DateTime paymentDate)
        {
            PaymentId = paymentId;
            UserId = userId;
            Amount = amount;
            Description = description;
            PaymentDate = paymentDate;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a User object
        User user = new User(1, "Gideon Adelaja", "adelajagideon@gmail.com");

        // Create Payment objects associated with the User
        List<Payment> payments = new List<Payment>()
        {
            new Payment(101, user.UserId, 125000.00m, "House Hold Item Purchase", DateTime.Now),
            new Payment(102, user.UserId, 250000.00m, "Dining Sets", DateTime.Now.AddDays(2))
        };
        Console.WriteLine("(1) A program defining two classes; User and Payment.\r\nUser class is related to Payment by UserId. in C#\r");
        Console.WriteLine("------------------------\n");

        // Display user information and associated payments
        Console.WriteLine("USER INFORMATION: ");
        Console.WriteLine("User ID: {0}", user.UserId);
        Console.WriteLine("Name: {0}", user.Name);
        Console.WriteLine("Email: {0}", user.Email);

        Console.WriteLine("\nAssociated Payments: ");
        foreach (Payment payment in payments)
        {
            Console.WriteLine("Payment ID: {0}", payment.PaymentId);
            Console.WriteLine("Amount: {0} Naira", payment.Amount);
            Console.WriteLine("Description: {0}", payment.Description);
            Console.WriteLine("Payment Date: {0}", payment.PaymentDate);
            Console.WriteLine();
        }

            //Question 2: Area of a triangle

            // Declare variables and then initialize to zero.
            double num1 = 0; double num2 = 0;

            // Display title of calculator app.
            Console.WriteLine("(2) A program that finds the area of a triangle in C#\r");
            Console.WriteLine("------------------------\n");

            // Ask the user to enter the base.
            Console.WriteLine("Enter the triangle's base, and then press Enter");
            num1 = Convert.ToDouble(Console.ReadLine());

            // Ask the user to enter the height.
            Console.WriteLine("Enter the triangle's height, and then press Enter");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The area of a triangle with base {num1} and height {num2} is " + 0.5 * (num1 * num2));

            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();


        }
    }
}
