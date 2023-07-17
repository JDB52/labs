using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class BankAccount
{
    public static int newAccountNumber = 100000;

    public string CustomerName { get; set; }
    public int AccountNumber { get; set; }
    public float Balance { get; set; }

    public BankAccount(string customerName) { 

        CustomerName = customerName;
        AccountNumber =
        Balance = 0;
    }
}
