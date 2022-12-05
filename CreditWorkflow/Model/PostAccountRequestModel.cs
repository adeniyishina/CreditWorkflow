namespace CreditWorkflow.Model
{
    public class PostAccountRequestModel
    {

        [JsonPropertyName("accountNumber")]
        public string? accountNumber { get; set; }

        public override string ToString()
        {
            return System.Text.Json.JsonSerializer.Serialize(this);
        }

    }
}
