using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using ATM_console_app;


Console.WriteLine(" Welcome to First bank!! ");
Console.WriteLine(" Do you have an account with us ");
Console.WriteLine("1. Yes");
Console.WriteLine("2. No");

int answer = Convert.ToInt32(Console.ReadLine());

if (answer == 1)
{
    List<Customer> customers = new List<Customer>()

    {
        new Customer { Name = "John", AccountNumber = "2301110001", Pin = 1234},
        new Customer { Name = "Mary", AccountNumber = "2301110002", Pin = 2222},
        new Customer { Name = "David", AccountNumber = "2301110003", Pin = 3333},
        new Customer { Name = "Sarah", AccountNumber = "2301110004", Pin = 4444},
        new Customer { Name = "James", AccountNumber = "2301110005", Pin = 5555},
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
    string Name = Console.ReadLine();

    Console.Write("Please enter your email address: ");
    string Email = Console.ReadLine();

    Console.Write("Enter your phone number: ");
    string phoneNumber = Console.ReadLine();

    Console.Write("Enter your BVN: ");
    string bvn = Console.ReadLine();

    Console.Write("Please create a pin: ");
    int password = Convert.ToInt32(Console.ReadLine());

   

    string AccountNumber = GenerateAccountNumber.NewAccountNumber();
    Console.WriteLine();
    Console.WriteLine(AccountNumber);
    Console.WriteLine( );
    Console.Write("your account number is: " + AccountNumber);
    Console.WriteLine();
    Console.WriteLine("Registration successful!");
    Console.WriteLine( );
    Customer newCustomer = new Customer
    {
        Name = Name,
        Email = Email,
        Pin = password,
        AccountNumber = AccountNumber
    };
    InternalStoragee.Add(newCustomer);
}
else
{
    Console.WriteLine("you entered a wrong input, restart and enter 1 or 2.");
    return;
}
Console.WriteLine();
Services.Service();