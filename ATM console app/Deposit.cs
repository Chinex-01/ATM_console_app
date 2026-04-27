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
                    }
                    else
                    {
                        Console.WriteLine(" invalid amount (must be in 1000 notes)");
                    }
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
                } while (answr == "yes");
            }
            else if ( answr == "no")
            {
                do
                {
                    Console.WriteLine(" alright. Noted!! ");
                    Services.Service();
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
