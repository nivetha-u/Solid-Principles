using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* To implement Single Responsibility Principle, we can create two classes
 * Now, AccountTransaction handles the transaction jobs
 * Each class has its own responsibilities following SRP
 */

namespace SolidPrinciples.SingleResponsibility.Srp
{
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
        public void UpdateBalance(double amount)
        {
            Balance = Balance +  amount;
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
}
