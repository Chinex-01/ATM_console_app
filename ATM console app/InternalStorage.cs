using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_console_app
{
    public class InternalStoragee
    {
        private static List<Customer> Storage { get; set; } = new List<Customer>();

        public static void Add(Customer customer)
        {
            Storage.Add(customer);
        }
    }
}
