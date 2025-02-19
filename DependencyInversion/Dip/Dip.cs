using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* By decoupling the PaymentProcessor from specific implementations, 
 * it becomes simpler to add or modify payment methods without altering the PaymentProcessor class.
 * Based on the object you send to PaymentProcessor, the appropriate ProcessPayment method would be called.
 */ 

namespace SolidPrinciples.DependencyInversion.Dip
{
    public interface ICardPayment
    {
        public void ProcessPayment(double amount);
    }

    public class DebitCard : ICardPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing Debit card payment of {amount}");
        }

    }
    public class CreditCard : ICardPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing Credit card payment of {amount}");
        }

    }
    public class PaymentProcessor
    {
        private readonly ICardPayment _cardPayment;
        public PaymentProcessor(ICardPayment cardPayment)
        {
            _cardPayment = cardPayment;
        }
        
        public void ExecutePayment(double amount)
        {

            _cardPayment.ProcessPayment(amount);
        }
    }

}
