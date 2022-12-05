using CreditWorkflow.Controllers;

namespace CreditWorkflow.Model
{
    public class RequestDebit
    {

        public decimal Amount { get; set; }

        public string? SourceAccount { get; set; }
        public string? DestinationAccount { get; set; }

        public bool ApplyFee { get; set; }

        public string? Narration { get; set; }

        public List<Fees> Fees { get; set; }
    }

    public class Fees
    {

        public string? Account { get; set; }

        public decimal Amount { get; set; }

        public string? Narration { get; set; }

    }
}
