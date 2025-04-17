using ExpenseReport.Services.Interfaces;

namespace ExpenseReport.Services.Implements
{
    public class ValidationService : IValidationService
    {

        public string ValidateInput(string input)
        {
            while (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Por favor, digite um valor válido: ");
                input = Console.ReadLine();
            }

            return input;
        }
    }
}