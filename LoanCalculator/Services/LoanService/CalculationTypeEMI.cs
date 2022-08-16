using System;
namespace LoanCalculator.Services.LoanService
{
    public class CalculationTypeEMI : LoanDecorator
    {
        public CalculationTypeEMI(LoanComponent component) : base(component)
        {

        }

        public override double Calculate(double loanAmount, double interestRate, int noOfPayments)
        {
            double r = interestRate;
            int n = noOfPayments;
            double P = loanAmount;

            double monthlyPayment = P * (r * Math.Pow(1 + r, n) / (Math.Pow(1 + r, n) - 1));
            return monthlyPayment;
        }
    }
}

