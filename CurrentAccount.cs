using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CurrentAccount : BankAccount
{
    public float OverdraftLimit { get; set; }

    public CurrentAccount(float overdraftLimit) 
    {
        OverdraftLimity = overdraftLimit;
    }

    public void Withdraw(float amount)
    {
        if (Balance - amount < OverdraftLimit)
        {
            Console.WriteLine("Not permitted")
                return;
        }

    }
}