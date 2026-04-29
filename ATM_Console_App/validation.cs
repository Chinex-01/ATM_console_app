using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using ATM_console_app;

namespace ATM_console_app
{
    class validation
    {
        public static void good()
        {
            Console.Write(" Please enter your name: ");
            string Name = Console.ReadLine();

            Console.Write(" Please enter your email address: ");
            string Email = Console.ReadLine();

            Console.Write(" Enter your phone number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write(" Enter your BVN: ");
            string bvn = Console.ReadLine();

            Console.Write(" Please create a pin: ");
            int password = 0;
            try
            {
                password = Convert.ToInt32(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine("Invalid PIN format. Use numbers only.");
                return;
            }
            string AccountNumber = GenerateAccountNumber.NewAccountNumber();
            Console.WriteLine();
            Console.WriteLine("Your new account Number: " + AccountNumber);
            Console.WriteLine();
            Console.WriteLine(" Registration successful!");
            Console.WriteLine();
            Customer newCustomer = new Customer
            {
                Name = Name,
                Email = Email,
                Pin = password,
                AccountNummber = AccountNumber
            };
            InternalStoragee.Add(newCustomer);
            Console.WriteLine(" your information has been stored: ");
            Console.WriteLine(" welcome " + Name + "!!");
            Console.Write("Enter your account number: ");
            string enteredaccountNumber = Console.ReadLine();


            if (enteredaccountNumber == AccountNumber)
            {
                bool isLoggedIn = false;
                while (true)
                {
                    Console.Write("Enter your PIN: ");

                    try
                    {
                        int enteredPin = Convert.ToInt32(Console.ReadLine());

                        if (enteredPin == password)
                        {
                            Console.WriteLine("Login successful! Welcome " + Name + "!!");
                            isLoggedIn = true;
                            Deposit.deposit();
                        }
                        else
                        {
                            Console.WriteLine("You entered a wrong PIN. Try again.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input. Please enter numbers for your PIN.");
                    }
                    break;

                }
            }
            else
            {
                Console.WriteLine("wrong input, restart your app");
                return;
            }

        }
    }
}