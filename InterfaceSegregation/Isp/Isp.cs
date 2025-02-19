using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* By creating seperate interfaces, the deriving class can implement interfaces which are only required.*/

namespace SolidPrinciples.InterfaceSegregation.Isp
{
    public interface IDepositable
    {
        void Deposit(double amount);
    }

    public interface IWithdrawable
    {
        void Withdraw(double amount);
    }

    public interface IInterestCalculable
    {
        void CalculateInterest();
    }

    public interface ILoanApplicable
    {
        void ApplyForLoan();
    }

    public class SavingsAccount : IDepositable, IWithdrawable, IInterestCalculable
    {
        public void Deposit(double amount) { Console.WriteLine("Deposited"); }
        public void Withdraw(double amount) { Console.WriteLine("Withdrawn"); }
        public void CalculateInterest() { Console.WriteLine("Interest calculated"); }
    }

}
