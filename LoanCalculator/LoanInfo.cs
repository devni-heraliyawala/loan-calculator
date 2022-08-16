using System;
namespace LoanCalculator
{
    public class LoanInfo
    {
        public CalculationType CalculationType { get; set; }
        public double LoanAmount { get; set; }
        public double InterestRate { get; set; }
        public int NoOfPayments { get; set; }
    }
}

