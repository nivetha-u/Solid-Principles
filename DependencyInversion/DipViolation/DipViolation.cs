using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Dependency Inversion Principle states that “High-level modules should not depend on low-level modules. 
 * Both should depend on abstractions“. 
 * Additionally, abstractions should not depend on details. Details should depend on abstractions.
 */
namespace SolidPrinciples.DependencyInversion.DipViolation
{
    public class DebitCard
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing Debit card payment of {amount}");
        }
    }

    /*Here, PaymentProcessor class is depending on lower level module DebitCard.
     * This is tight-coupling to DebitCard class
     * If in future, a new payment is introduced, we need to create another object of it modifying the class.
     */
    public class PaymentProcessor
    {
        public void ExecutePayment(double amount)
        {
            var debitCard = new DebitCard();
            debitCard.ProcessPayment(amount);
        }
    }
}
