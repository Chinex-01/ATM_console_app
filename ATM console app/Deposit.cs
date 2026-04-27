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

           string yes  ;
           string no ;
            if (answr == yes)
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
                    break;
                } while (answr == yes);
            }
            else
            {
                do
                {
                    Console.WriteLine(" alright. Noted!! ");
                    Services.Service();
                    break;
                } while (answr == no);
            }
        }
    }
}
