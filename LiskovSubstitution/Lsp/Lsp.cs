using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Each derived class overrides the CalculateInterest method to implement account-specific interest calc.
 * In the Main method, we create objects for SavingsAccount and CurrentAccount but define them as BankInterest types. 
 * This follows the LSP, which allows us to replace instances of derived classes with the base class without affecting the behaviour.
 */

namespace SolidPrinciples.LiskovSubstitution.Lsp
{
    public abstract class BankInterest
    {
        public double Balance { get; private set; }

        public BankInterest(double balance)
        {
            Balance = balance;
        }
        public abstract double CalculateInterest();
    
    }
    public class SavingsAccount : BankInterest
    {
        public SavingsAccount(double balance) : base(balance)
        {
        }
        public override double CalculateInterest()
        {
            return 0.01 * Balance;
        }
    }
    public class CurrentAccount : BankInterest
    {
        public CurrentAccount(double balance) : base(balance)
        {
        }
        public override double CalculateInterest()
        {
            return 0.03 * Balance;
        }
    }

}
