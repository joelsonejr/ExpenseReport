namespace ExpenseReport.Data.DataTransferObjects
{
    public class PersonDto
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public List<ExpenseDto>? Expenses { get; set; } = new List<ExpenseDto>();

        override public string ToString()
        {
            return string.Format($"Nome: {Name} - Id: {PersonId}");
        }
    }
}