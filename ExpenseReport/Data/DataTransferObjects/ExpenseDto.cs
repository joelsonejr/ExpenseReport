namespace ExpenseReport.Data.DataTransferObjects
{
    public class ExpenseDto
    {
        public int ExpanseId { get; set; }
        public int PersonId { get; set; }
        public DateTimeOffset Date { get; set; }
        public string? Description { get; set; }
        public double Value { get; set; }

        override public string ToString()
        {
            return string.Format($"Data: {Date.Date} - Valor: {Value} - Descrição: {Description}");
        }

    }
}