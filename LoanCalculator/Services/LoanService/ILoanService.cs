using System;
namespace LoanCalculator.Services.LoanService
{
    public interface ILoanService
    {
        Task<ServiceResponse<double>> CalculateMonthlyPayment(LoanInfo loanInfo);

    }
}

