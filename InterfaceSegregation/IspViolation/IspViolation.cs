using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Interface Segregation states that “do not force any client to implement an interface which is irrelevant to them“.
 * In the below code, we are forcing SavingsAccount class to implement Loan Method which is not applicable to it.
 */


namespace SolidPrinciples.InterfaceSegregation.IspViolation
{
    public interface IBankAccount
    {
        public void Deposit(double amount);
        public void Withdraw(double amount);
        public void CalculateInterest();
        public void ApplyForLoan();
    }

    public class SavingsAccount : IBankAccount
    {
        public void Deposit(double amount) { Console.WriteLine("Deposited in Savings"); }
        public void Withdraw(double amount) { Console.WriteLine("Withdrawn from Savings"); }
        public void CalculateInterest() { Console.WriteLine("Interest calculated"); }

        // Not applicable for SavingsAccount
        public void ApplyForLoan()
        {
            throw new NotImplementedException("Savings account can't apply for a loan.");
        }
    }

    public class LoanAccount : IBankAccount
    {
        public void ApplyForLoan() { Console.WriteLine("Loan applied"); }

        //Not applicable for LoanAccount
        public void Deposit(double amount)
        {
            throw new NotImplementedException("Loan account doesn't support deposits.");
        }

        public void Withdraw(double amount)
        {
            throw new NotImplementedException("Loan account doesn't support withdrawals.");
        }

        public void CalculateInterest() { Console.WriteLine("Loan interest calculated"); }
    }

}
