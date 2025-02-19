using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* L - Liskov's Substituion Principle stated that Derived or child classes must be
 * substitutable for their base or parent classes without changing its behaviour“.
 * i.e If we successfully replace the instance of a parent class with an instance of the child class 
 * without affecting the behavior of the base class instance, it is said to be in Liskov Substitution Principle. 
 */

namespace SolidPrinciples.LiskovSubstitution.LspViolating
{
    public class BankInterest
    {
        public double Balance { get; private set; }

        public string? AccountType { get; private set; }

       
       public virtual double CalculateInterest()
        {
            return 0.02 * Balance;
        } 

    }
    public class BankInterestCalculator : BankInterest
     {
        // In this example, The child class BankInterestCalculator overrides the CalculateInterest method,
        // but for invalid account type it is throwing exception which is not a behaviour of parent class.
        // Here, we are changing the behaviour of parent class which makes it non substitutable.
        public BankInterestCalculator(double balance,string accountType) { }
        public override double CalculateInterest()
        {
                if (AccountType == "Current") return 0.03 * Balance;
                else if (AccountType == "Savings") return 0.01 * Balance;
                else throw new InvalidOperationException("Invalid account type.");
        }
    }
}
