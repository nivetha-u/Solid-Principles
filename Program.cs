// See https://aka.ms/new-console-template for more information

using SolidPrinciples.SingleResponsibility.Srp;
using SolidPrinciples.DependencyInversion.Dip;
using SolidPrinciples.OpenClosed.Interface;
using SolidPrinciples.OpenClosed.Ocp;
using SolidPrinciples.LiskovSubstitution.Lsp;

class Program
{
    static void Main(string[] args)

    {
        // For Single Responsibility
        Console.WriteLine("Single Responsibility Principle");
        var account = new SolidPrinciples.SingleResponsibility.Srp.BankAccount(12345678,"Nivetha");
        var transaction = new SolidPrinciples.SingleResponsibility.Srp.AccountTransaction(account);
        transaction.Deposit(1000);
        transaction.Withdraw(500);

        // For Open-Closed
        Console.WriteLine("Open-Closed Principle");
        var accountOCP = new SolidPrinciples.OpenClosed.Ocp.BankAccount(12345678, "Nivetha","Savings");
        IInterestCalculator savings = new SavingsAccountInterest();
        double interest = savings.CalculateInterest(accountOCP);
        Console.WriteLine(interest);

        // For LisKov Substitution
        Console.WriteLine("Liskov Substitution Principle");
        BankInterest bankInterest = new SavingsAccount(10000);
        double calculatedInterest = bankInterest.CalculateInterest();
        Console.WriteLine(calculatedInterest);

        // For Dependency Inversion
        Console.WriteLine("Dependency Inversion Principle");
        var creditCard = new CreditCard();
        var debitCard = new DebitCard();
        PaymentProcessor _paymentProcessor = new PaymentProcessor(creditCard);
        PaymentProcessor _paymentProcessorObj = new PaymentProcessor(debitCard);
        _paymentProcessor.ExecutePayment(1000);
        _paymentProcessorObj.ExecutePayment(5000);
    }
}