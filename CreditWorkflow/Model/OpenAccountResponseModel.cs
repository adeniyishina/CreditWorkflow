namespace CreditWorkflow.Model
{
    public class OpenAccountResponseModel
    {

        [JsonPropertyName("custNo")]
        public string custNo { get; set; }

        [JsonPropertyName("accountNo")]
        public string accountNo { get; set; }

        public override string ToString()
        {
            return System.Text.Json.JsonSerializer.Serialize(this);
        }

    }
}
