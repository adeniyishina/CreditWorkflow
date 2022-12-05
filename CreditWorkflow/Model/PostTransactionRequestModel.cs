
using System.Text.Json.Serialization;

namespace CreditWorkflow.Model
{
   
    public class PostTransactionRequestModel
    {
        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }

        [JsonPropertyName("applyFee")]
        public bool ApplyFee { get; set; }

        [JsonPropertyName("chequeNo")]
        public string ChequeNo { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("destinationAccount")]
        public string DestinationAccount { get; set; }

        [JsonPropertyName("externalReference")]
        public string ExternalReference { get; set; }

        [JsonPropertyName("fees")]
        public List<Fee> Fees { get; set; }

        [JsonPropertyName("narration")]
        public string Narration { get; set; }

        [JsonPropertyName("noOfDays")]
        public int NoOfDays { get; set; }

        [JsonPropertyName("sourceAccount")]
        public string SourceAccount { get; set; }

        [JsonPropertyName("transType")]
        public string TransType { get; set; }

        [JsonPropertyName("transferReference")]
        public string TransferReference { get; set; }

        [JsonPropertyName("trnCode")]
        public string TrnCode { get; set; }
    }


    public class Fee
    {
        [JsonPropertyName("account")]
        public string Account { get; set; }

        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }

        [JsonPropertyName("feeOn")]
        public string FeeOn { get; set; }

        [JsonPropertyName("narration")]
        public string Narration { get; set; }

        [JsonPropertyName("trnCode")]
        public string TrnCode { get; set; }

        public override string ToString()
        {
            return System.Text.Json.JsonSerializer.Serialize(this);
        }
    }

    

}
