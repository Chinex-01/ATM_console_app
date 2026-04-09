using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using ATM_console_app; 

namespace nonso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to First bank!! ");
            Console.WriteLine(" Do you have an account with us ");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1)
            {
                List<Customer> customers = new List<Customer>()
    {
        new Customer { Name = "John", AccountNumber = "2301110001", Pin = 1234, ID = 1},
        new Customer { Name = "Mary", AccountNumber = "2301110002", Pin = 2222, ID = 2 },
        new Customer { Name = "David", AccountNumber = "2301110003", Pin = 3333, ID = 3 },
        new Customer { Name = "Sarah", AccountNumber = "2301110004", Pin = 4444, ID = 4},
        new Customer { Name = "James", AccountNumber = "2301110005", Pin = 5555, ID = 5},
    };
                Console.Write("Enter your account number: ");
                string? accountnumber = Console.ReadLine();
                Customer? Custoomer = null;
                foreach (var customer in customers)
                {
                    if (customer.AccountNumber == accountnumber)
                    {
                        Custoomer = customer;
                        break;
                    }
                }
                if (Custoomer != null)
                {
                      Console.Write("Enter your 4-digit pin: ");
                        int password = Convert.ToInt32(Console.ReadLine());

                        if (Custoomer.Pin == password)
                        {
                            Console.WriteLine("Login successful");
                        }
                        else
                        {
                            Console.WriteLine("Incorrect pin, try again");
                            Console.WriteLine("Restart your app");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("You don't have an account with us.");
                    Console.WriteLine("Restart your app");
                    return;
                }
            }
            else if (answer == 2)
            {
                Console.Write("Please enter your name: ");
                string name = Console.ReadLine();

                Console.Write("Please enter your email address: ");
                string email = Console.ReadLine();

                Console.Write("Enter your phone number: ");
                string phoneNumber = Console.ReadLine();

                Console.Write("Enter your BVN: ");
                string bvn = Console.ReadLine();

                Console.Write("Please create a pin: ");
                int password = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Your details: {name}, {email}, {phoneNumber}, {password}, {bvn}");
                Console.WriteLine("Registration successful!");
            }
            else
            {
                Console.WriteLine("you entered a wrong input, restart and enter 1 or 2.");
                return;
            }
                Console.WriteLine();
                bool yes = true;
                bool no = false;
                while (yes)
                {
                Services.Service();
                string answerr = Console.ReadLine();
                    if (answerr == "no")
                    {
                        Console.WriteLine("Thank you for banking with us ");
                        Console.WriteLine("Have a nice day!!");
                        break;
                    }
                }
            }
    }
}
