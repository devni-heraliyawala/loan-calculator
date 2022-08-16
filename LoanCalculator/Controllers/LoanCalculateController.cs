using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoanCalculator.Controllers
{
    [Route("api/[controller]")]
    public class LoanCalculateController : Controller
    {
        private readonly ILoanService _loanService;

        public LoanCalculateController(ILoanService loanService)
        {
            _loanService = loanService;
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<double>>> CalculateMonthlyPayment(LoanInfo loanInfo)
        {
            var result = await _loanService.CalculateMonthlyPayment(loanInfo);
            return Ok(result);
        }

    }
}

