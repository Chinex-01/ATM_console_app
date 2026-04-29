using ATM_console_app;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

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
                  new Customer { Name = "John", AccountNummber = "2301110001", Pin = 1234, amount = 1000},
                  new Customer { Name = "Mary", AccountNummber = "2301110002", Pin = 2222, amount = 570},
                  new Customer { Name = "David", AccountNummber = "2301110003", Pin = 3333, amount = 8700},
                  new Customer { Name = "Sarah", AccountNummber = "2301110004", Pin = 4444, amount = 109000},
                  new Customer { Name = "James", AccountNummber = "2301110005", Pin = 5555, amount = 2054000},
                };
                Console.Write(" Enter your account number: ");
                string? accountnumber = Console.ReadLine();
                Customer? Custoomer = null;
                foreach (var customer in customers)
                {
                    if (customer.AccountNummber == accountnumber)
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
                        Console.WriteLine(" Login successful");
                        Services.Service();
                    }
                    else
                    {
                        Console.WriteLine(" Incorrect pin, try again");
                        Console.WriteLine(" Restart your app");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine(" You don't have an account with us.");
                    Console.WriteLine(" Restart your app");
                    return;
                }
            }
            else if (answer == 2)
            {
                validation.good();
            }
            else
            {
                Console.WriteLine(" you entered a wrong input, restart and enter 1 or 2.");
                return;
            }

        }
    }
}