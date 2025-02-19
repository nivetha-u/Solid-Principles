using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidPrinciples.OpenClosed.Ocp;

/* An interface IInterestCalculator is created and for each account type we create a separate class
 * implementing this interface and overriding the method CalculateInterest. 
/* When a new type comes in future, we just need to create another class for it.
*/

namespace SolidPrinciples.OpenClosed.Interface
{
    public interface IInterestCalculator
    {
        public double CalculateInterest(BankAccount account);

    }

    public class SavingsAccountInterest : IInterestCalculator
    {
        public double CalculateInterest(BankAccount account)
        {
            return 0.2 * account.Balance;
        }
    }
    public class CurrentSavingsInterest : IInterestCalculator
    {
        public double CalculateInterest(BankAccount account)
        {
            return 0.3 * account.Balance;
        }
    }

}
