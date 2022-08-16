using System;

namespace LoanCalculator.Services.LoanService
{
    public class LoanService : ILoanService
    {
        public LoanService()
        {
        }

        public async Task<ServiceResponse<double>> CalculateMonthlyPayment(LoanInfo loanInfo)
        {
            double monthlyPayment;
            var calculationType = loanInfo.CalculationType;
            var loanAmount = loanInfo.LoanAmount;
            var interestRate = loanInfo.InterestRate;
            var noOfPayments = loanInfo.NoOfPayments;

            LoanComponent component = new ConcreteComponent();

            switch (calculationType)
            {
                case CalculationType.EMI:
                    component = new CalculationTypeEMI(component);
                    break;
                // Extensibility for other calculation types
                case CalculationType.TEST:
                    break;
                // Extensibility for other calculation types
                default:
                    component = new CalculationTypeEMI(component);
                    break;
            }
            monthlyPayment =component.Calculate(loanAmount,interestRate,noOfPayments);

            return new ServiceResponse<double> { Data = monthlyPayment };
        }
    }
}

