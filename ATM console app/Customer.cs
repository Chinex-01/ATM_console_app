using System;
using System.Collections.Generic;
using System.Text;
using ATM_console_app;

namespace ATM_console_app
{
    public class Customer
    {
        public string Name { get; set; }
        public string? AccountNumber { get; set; }
        public int Pin { get; set; }
        public string Email { get; set; }
        public double amount { get; set; }
    }
    }