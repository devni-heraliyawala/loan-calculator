using System;
namespace LoanCalculator.Services.LoanService
{
    public class LoanDecorator: LoanComponent
    {

        protected LoanComponent _component;

        public LoanDecorator(LoanComponent component)
        {
            _component = component;
        }

        public override double Calculate(double loanAmount, double interestRate, int noOfPayments)
        {
            if (_component != null)
            {
                return _component.Calculate(loanAmount,interestRate,noOfPayments);
            }
            else
            {
                return 0;
            }
        }
    }
}

