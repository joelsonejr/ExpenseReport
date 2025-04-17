using System.Data.Common;
using ExpenseReport.Data.DataTransferObjects;
using ExpenseReport.Services.Implements;

namespace ExpenseReport.Services.Interfaces
{
    public interface IPersonService
    {
        public PersonDto CreatePerson(ValidationService validation);

    }
}