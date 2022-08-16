using System;
namespace LoanCalculator.Services
{
    public abstract class LoanComponent
    {
        public abstract double Calculate(double loanAmount, double interestRate, int noOfPayments);
    }
}

