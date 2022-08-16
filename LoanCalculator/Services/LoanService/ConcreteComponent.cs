using System;

namespace LoanCalculator.Services.LoanService
{
    public class ConcreteComponent: LoanComponent
    {
        public override double Calculate(double loanAmount, double interestRate, int noOfPayments)
        {
            return 0;
        }
    }
}

