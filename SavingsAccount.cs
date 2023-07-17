using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SavingsAccount : BankAccount
{
    public float InterestRate{ get; set; }

    public SavingsAccount(string customerName)
    {
        InterestRate = 1.5;
    }

    public void AddInterest()
    {
        float newInterest = Balance * (InterestRate / 100);
        Balance += newInterest
    }
}