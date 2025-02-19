using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* O stands for Open - Closed Principle
 * This principle states that "Software entities (classes, modules, functions, etc.) should be 
 * open for extension, but closed for modification” 
 * which means you should be able to extend a class behavior, without modifying it.
 */

namespace SolidPrinciples.OpenClosed.OcpViolating
{
    public class BankAccount
    {
        public int AccountNumer { get; private set; }
        public string Name { get; private set; }
        public double Balance { get; private set; }

        public string AccountType { get; private set; }

        public BankAccount(int accountNumber, string name, string accountType)
        {
            AccountNumer = accountNumber;
            Name = name;
            Balance = 0;
            AccountType = accountType;
        }
        public void UpdateBalance(double amount)
        {
            Balance = Balance + amount;
        }


    }
    public class AccountTransaction
    {
        private readonly BankAccount _account;
        public AccountTransaction(BankAccount account)
        {
            _account = account;
        }

        public void Deposit(double amount)
        {
            _account.UpdateBalance(amount);
            Console.WriteLine($"Deposited ${amount}. New Balance: ${_account.Balance}");
        }
        public void Withdraw(double amount)
        {
            _account.UpdateBalance(-amount);
            Console.WriteLine($"Withdrew ${amount}. New Balance: ${_account.Balance}");
        }
    }

    /* The InterestCalculator class calculates the interest for each type of bank accounts
     * Say, in future we introduce a new type of account, then we need to modify this class to add calculations
     * We are modifying the class which violates OCP 
     */
    public class InterestCalculator
    {
        public double CalculateInterest(BankAccount account)
        {
            if (account.AccountType == "Current") return 0.3 * account.Balance;
            else if (account.AccountType == "Savings") return 0.2 * account.Balance;
            else return 0.4 * account.Balance;
        }
    }
}
