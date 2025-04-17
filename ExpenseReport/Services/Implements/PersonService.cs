using System.Reflection.Metadata.Ecma335;
using ExpenseReport.Data.DataTransferObjects;
using ExpenseReport.Services.Interfaces;

namespace ExpenseReport.Services.Implements
{
    public class PersonService : IPersonService
    {
        public int RandonId { get; set; } = 10;

        public PersonDto CreatePerson(ValidationService validation)
        {
            Console.Write("Digite o nome: ");
            string name = validation.ValidateInput(Console.ReadLine());

            int id = RandonId;
            RandonId++;

            return new PersonDto()
            {
                PersonId = id,
                Name = name,
            };
        }

    }
}