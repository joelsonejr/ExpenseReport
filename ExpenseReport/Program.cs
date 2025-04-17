using System.ComponentModel.DataAnnotations;
using ExpenseReport.Data.DataTransferObjects;
using ExpenseReport.Services;
using ExpenseReport.Services.Implements;

namespace ExpenseReport
{
    class Program
    {
        public static void Main(string[] args)
        {
            ValidationService _validation = new ValidationService();
            ExpenseService _expense = new ExpenseService();
            PersonService _person = new PersonService();

            List<PersonDto> newPersons = new List<PersonDto>();

            Console.Write("Digite 1 para cadastrar uma pessoa, 2 para cadastrar um novo gasto: ");
            string inputOption = _validation.ValidateInput(Console.ReadLine());

            int option = int.Parse(inputOption);

            if (option != 1 && option != 2)
            {
                throw new ArgumentException();
            }

            if (option == 1)
            {
                newPersons = _person.CreatePerson(_validation);
            }


            Console.WriteLine("Quantas despesas deseja cadastrar: ");
            string inputAmount = _validation.ValidateInput(Console.ReadLine());

            int amount = int.Parse(inputAmount);

            if (amount < 1)
            {
                return;
            }

            List<ExpenseDto> expenseP1 = _expense.PopulateExpenseList(amount, _validation);


            if (expenseP1.Count() > 0)
            {
                _expense.ListExpense(expenseP1);
            }


            if (newPersons.Count() > 0)
            {
                _person.ListPerson(newPersons);
            }

        }
    }
}
