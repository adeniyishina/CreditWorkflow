

using System.Text.Json.Serialization;
using static CreditWorkflow.Model.NameEquiryResponsecs;

namespace CreditWorkflow.Model
{
    public class TransactionResponseBaseModel<T>
    {

        [JsonPropertyName("respMsg")]
        public string RespMsg { get; set; }

        [JsonPropertyName("respCode")]
        public int RespCode { get; set; }

        [JsonPropertyName("data")]
        public Data Data { get; set; }

        public override string ToString()
        {
            return System.Text.Json.JsonSerializer.Serialize(this);
        }

        ////[JsonPropertyName("respMsg")]
        ////public string RespMsg { get; set; }

        ////[JsonPropertyName("respCode")]
        ////public int RespCode { get; set; }

        ////[JsonPropertyName("data")]
        ////public T Data { get; set; }
    }
}
