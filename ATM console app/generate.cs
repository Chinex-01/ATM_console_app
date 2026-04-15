using ATM_console_app;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_console_app
{
    public static class GenerateAccountNumber
    {
            public static string  NewAccountNumber ()
            {
            const string numberStatic = "230111";
            Random rand = new Random();
            string accId = ""; 

            for (int i = 0; i < 4; i++ )
            {
                int randNumber = rand.Next(0, 9);
                accId += randNumber.ToString();
            }
            string UserAccountNumber = numberStatic + accId; 
            return $"Your new account Number: {UserAccountNumber}";
        }
    }
}
