using System;
using System.Collections.Generic;
namespace nonso
{
    class Program
    {
        static void Main(string[] args)
        {
            // register
            Console.WriteLine(" Welcome to First bank!! ");
            Console.WriteLine(" Do you have an account with us ");
            Console.WriteLine(1 + ". yes");
            Console.WriteLine(2 + ". No");
            int answer = Convert.ToInt32(Console.ReadLine());
            int yeah = 1;
            int nah = 2;
            if (answer == yeah)
            {
                Console.Write(" Enter your account number: ");
                var accountnumber = Console.ReadLine();
                Console.Write(" Enter your 4 digits pin: ");
                int password = Convert.ToInt32(Console.ReadLine());
            }
            else if (answer == nah)
            {
                Console.Write(" Please enter your name: ");
                string name = Console.ReadLine();
                Console.WriteLine();
                Console.Write(" Please enter your email address: ");
                string email = Console.ReadLine();
                Console.WriteLine();
                Console.Write(" Enter your phone number: ");
                string phonenumber = Console.ReadLine();
                Console.WriteLine();
                Console.Write(" Enter your bvn: ");
                var bvn = Console.ReadLine();
                Console.WriteLine();
                Console.Write(" Please create a pin: ");
                int password = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" your datails : " + name + " " + email + ", " + phonenumber + " , " + password + " ," + bvn + " .");
            }
            else
            {
                Console.Write(" error, pls enter a number from (1 - 3)");
            }
           
            bool yes = true;
            bool no = false;
            double balance = 0.00;


            while (yes)
            {
                int deposit = 1;
                int checkbalance = 2;
                int withdraw = 3;
                int changepin = 4;
                int phonenumeber = 5;
                int choice;

                Console.WriteLine(" Which service do you want ");
                Console.WriteLine(1 + " Deposit");
                Console.WriteLine(2 + " check balance");
                Console.WriteLine(3 + " Withdraw ");
                Console.WriteLine(4 + " change pin");
                Console.WriteLine(5 + " update phone number");

                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == deposit) // Deposit (only accepts 1000 naira notes)
                {
                    do
                    {
                        Console.Write(" Enter the amount you want to deposit ?: ");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        if (amount > 0 && amount % 1000 == 0)
                        {
                            balance += amount;
                            Console.WriteLine("deposit successfully");
                            Console.WriteLine("current balance: " + balance);
                        }
                        else
                        {
                            Console.WriteLine("invalid amount (must be in 1000 notes)");
                        }
                        break;
                    } while (choice == deposit);
                }
                else if (choice == checkbalance) // Check balance
                {
                    do
                    {
                        Console.WriteLine("Balance : " + balance);
                        break;
                    } while (choice == checkbalance);
                }
                else if (choice == withdraw)  // withdraw (accepts only 100 notes)
                {
                    do
                    {
                        Console.Write(" Enter the amount you want to withdraw ?: ");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        if (amount > 0 && amount % 1000 == 0 && amount <= balance)
                        {
                            balance -= amount;
                            Console.WriteLine("withdrawal successful");
                            Console.WriteLine("current balance: " + balance);
                        }
                        else
                        {
                            Console.WriteLine("invalid amount");
                        }
                        break;
                    } while (choice == withdraw);
                }
                else if (choice == changepin) // change pin 
                {
                    // change pin
                    string currentpin = "1234";
                    Console.Write(" Enter your current pin: ");
                    string currentpininput = Convert.ToString(Console.ReadLine());
                    if (currentpininput != currentpin) Console.WriteLine(" incorrect pin.");
                    string newPin;
                    string newPin2;
                    do
                    {
                        Console.Write("Enter new PIN: ");
                        newPin = Console.ReadLine();
                        Console.Write("Retype new PIN: ");
                        newPin2 = Console.ReadLine();
                        if (newPin != newPin2) Console.WriteLine(" Don't match, Try again.");
                    } while (newPin != newPin2);
                    string currentPin = newPin;
                    Console.WriteLine(" success, New PIN: " + newPin);
                }
                else if (choice == phonenumeber)
                {
                    Console.WriteLine("Enter your old number: ");
                    string oldnum = Console.ReadLine();

                    Console.WriteLine("Enter your new number: ");
                    string newnum = Console.ReadLine();
                 
                    Console.WriteLine("Re-enter your new number: ");
                    string newnum1 = Console.ReadLine();

                    Console.WriteLine( " ");

                    if (newnum == newnum1)
                    {
                        Console.WriteLine(" your change was sucessfully ");
                    }
                    else
                    {
                        Console.WriteLine("Both don't match ");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number, Enter number from (1- 4)");
                }

                Console.WriteLine(" DO you want to use any of our services (yes/no)");
                string answerr = Console.ReadLine();

                if (answerr == "no")
                {
                    Console.WriteLine("Thank you for banking with us ");
                    break; 
                }
               
            }

        }
    }
}
