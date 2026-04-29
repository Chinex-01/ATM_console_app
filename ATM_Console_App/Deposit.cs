using System;
using System.Collections.Generic;
using System.Text;
using ATM_console_app;
namespace ATM_console_app
{
    public static class Deposit
    {
        public static void deposit()
        {

            double balance = 0.00;
            Console.WriteLine(" It's advisable for you to deposit after opening an account ");
            Console.WriteLine(" Do you want to deposit (yes / no )");
            var answr = Console.ReadLine();
            if (answr?.ToLower() == "yes")
            {
                do
                {
                    Console.Write(" Enter the amount you want to deposit ?: ");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    if (amount > 0 && amount % 1000 == 0)
                    {
                        balance += amount;
                        Console.WriteLine(" deposit successfully");
                        Console.WriteLine(" current balance: " + balance);
                        Console.Write(" Do you want to do another service us (yes/no): ");
                        string answerr = Console.ReadLine();
                        if (answerr == "no")
                        {
                            Console.WriteLine(" Thank you for banking with us ");
                            Console.WriteLine(" Have a nice day!!");
                            break;
                        }
                        else
                        {
                            bool yes = true;
                            bool no = false;

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
                                        double amounnt = Convert.ToDouble(Console.ReadLine());
                                        if (amounnt > 0 && amounnt % 1000 == 0)
                                        {
                                            balance += amounnt;
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
                                        double amountt = Convert.ToDouble(Console.ReadLine());
                                        if (amountt > 0 && amountt % 1000 == 0 && amountt <= balance)
                                        {
                                            balance -= amountt;
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
                                        Console.Write("mEnter new PIN: ");
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
                                    Console.Write(" Enter your old number: ");
                                    string oldnum = Console.ReadLine();

                                    Console.Write(" Enter your new number: ");
                                    string newnum = Console.ReadLine();

                                    Console.Write(" Re-enter your new number: ");
                                    string newnum1 = Console.ReadLine();
                                    Console.WriteLine(" ");
                                    if (newnum == newnum1)
                                    {
                                        Console.WriteLine(" your change was sucessfully ");
                                    }
                                    else
                                    {
                                        Console.WriteLine(" Both don't match");
                                        Console.WriteLine(" it wasnt updated");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(" Invalid number, Enter number from (1 - 4)");
                                }
                                Console.Write(" Do you want to do another service us (yes/no): ");
                                string answeerr = Console.ReadLine();
                                if (answeerr == "no")
                                {
                                    Console.WriteLine(" Thank you for banking with us ");
                                    Console.WriteLine(" Have a nice day!!");
                                    break;
                                }
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(" invalid amount (must be in 1000 notes)");
                    }

                    break;
                } while (answr == "yes");
            }
            else if (answr == "no")
            {
                do
                {
                    Console.WriteLine(" alright. Noted!! ");
                    Console.Write(" Do you want to do another service us (yes/no): ");
                    string answerr = Console.ReadLine();
                    if (answerr == "no")
                    {
                        Console.WriteLine(" Thank you for banking with us ");
                        Console.WriteLine(" Have a nice day!!");
                        break;
                    }
                    else
                    {
                        Services.Service();
                    }
                    break;
                } while (answr == "no");
            }
            else
            {
                Console.WriteLine(" Have a nive day!! ");
            }
            return;
        }
    }
}