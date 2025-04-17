using System.Reflection.Metadata.Ecma335;
using ExpenseReport.Data.DataTransferObjects;
using ExpenseReport.Services.Interfaces;

namespace ExpenseReport.Services.Implements
{
    public class PersonService : IPersonService
    {
        public int RandonId { get; set; } = 10;

        public List<PersonDto> CreatePerson(ValidationService validation)
        {
            int repeat = 1;

            List<PersonDto> persons = new List<PersonDto>();

            while (repeat != 0)
            {
                Console.Write("Digite o nome: ");
                string name = validation.ValidateInput(Console.ReadLine());

                int id = RandonId;

                persons.Add(new PersonDto()
                {
                    Name = name,
                    PersonId = id
                });

                RandonId++;

                Console.Write("Deseja adicionar outra pessoa? 1 = sim, 0 - não: ");
                repeat = int.Parse(Console.ReadLine());

            }

            return persons;
        }

        public void ListPerson(List<PersonDto> list)
        {
            foreach (var person in list)
            {
                Console.WriteLine(person);
            }
        }

    }
}