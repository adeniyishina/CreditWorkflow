
using System.Text.Json.Serialization;

namespace CreditWorkflow.Model
{
    public class PostTransactionResponseModel
    {
        [JsonPropertyName("referenceNo")]
        public string ReferenceNo { get; set; }

        [JsonPropertyName("transactionStatus")]
        public string TransactionStatus { get; set; }

        [JsonPropertyName("valueDate")]
        public DateTime ValueDate { get; set; }

        [JsonPropertyName("narration")]
        public string Narration { get; set; }

        [JsonPropertyName("chargeRef")]
        public object ChargeRef { get; set; }

        public override string ToString()
        {
            return System.Text.Json.JsonSerializer.Serialize(this);
        }
    }
}
