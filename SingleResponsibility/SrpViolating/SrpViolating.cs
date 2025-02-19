using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

/*
S - Single Responsibility Priciple
This principle states that a class should have only one responsibility or job within a software systenm.(i.e) There
should be only one reason to change that class.
*/

namespace SolidPrinciples.SingleResponsibility.SrpViolating
{
    // We have a BankAccount Class which basically is for storing back account details of customer. 
    // But, it also does transaction jobs (deposit, withdraw) which is out of scope of the class.

    public class BankAccount 
    {
        public int AccountNumer { get; private set; }
        public string Name { get; private set; }
        public double Balance { get; private set; }

        public BankAccount(int accountNumber, string name)
        {
            AccountNumer = accountNumber;
            Name = name;
            Balance = 0;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ${amount}. New Balance: ${Balance}");
        }
        public void Withdraw(double amount)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew ${amount}. New Balance: ${Balance}");         
        }

    }
    /* Now, if we want to do some changes in deposit, then we are changing the BankAccount class 
     * for other functionality which violates SRP.
     */
}
