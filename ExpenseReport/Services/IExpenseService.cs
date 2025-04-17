using ExpenseReport.Data.DataTransferObjects;
using ExpenseReport.Services;
using ExpenseReport.Services.Implements;

namespace ExpenseReport.Services.Interfaces
{
    public interface IExpenseService
    {
        public List<ExpenseDto> PopulateExpenseList(int listLength, ValidationService validation);

    }
}