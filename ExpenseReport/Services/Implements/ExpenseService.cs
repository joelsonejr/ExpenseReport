using ExpenseReport.Data.DataTransferObjects;
using ExpenseReport.Services.Interfaces;

namespace ExpenseReport.Services.Implements
{
    public class ExpenseService : IExpenseService
    {

        public List<ExpenseDto> PopulateExpenseList(int listLength, ValidationService validation)
        {

            List<ExpenseDto> expenseList = new List<ExpenseDto>();

            for (int i = 0; i < listLength; i++)
            {
                Console.Write($"Digite a data da despesa {i + 1}: ");
                string inputedDate = validation.ValidateInput(Console.ReadLine());

                DateTimeOffset date = DateTimeOffset.Parse(inputedDate);

                Console.Write($"Digite a descrição da despesa {i + 1}: ");
                string description = validation.ValidateInput(Console.ReadLine());



                Console.Write($"Digite o valor da despesa {i + 1}: R$ ");
                string inputedValue = validation.ValidateInput(Console.ReadLine());

                double value = double.Parse(inputedValue);


                expenseList.Add(CreateExpense(date, description, value));

            }
            return expenseList;
        }

        public ExpenseDto CreateExpense(DateTimeOffset date, string description, double value)
        {
            return (new ExpenseDto
            {
                Date = date,
                Description = description ?? "----",
                Value = value
            });
        }

        public void ListExpense(List<ExpenseDto> list)
        {
            foreach (var expense in list)
            {
                Console.WriteLine(expense);
            }
        }
    }
}