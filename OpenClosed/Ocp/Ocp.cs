using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidPrinciples.OpenClosed.Interface;

/* When a new requirement or change come at any time, instead of touching the existing functionality,
 * it’s always better to create new derived classes
 * and leave the original class implementation as it is.
 * By using interface, we followed the OCP
 */
namespace SolidPrinciples.OpenClosed.Ocp
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
            Balance = 10000;
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
    public class InterestCalculator
    {
        private readonly IInterestCalculator _interestCalculator;

        public InterestCalculator(IInterestCalculator interestCalculator)
        {
            _interestCalculator = interestCalculator;
        }
        public double CalculateInterest(BankAccount account)
        {
            return _interestCalculator.CalculateInterest(account);
        }
    }
}
