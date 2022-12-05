namespace CreditWorkflow.Model
{
    public class RequestBVNModel
    {
        [JsonPropertyName("BVN")]
        public string BVN { get; set; }

        public override string ToString()
        {
            return System.Text.Json.JsonSerializer.Serialize(this);
        }

    }
}
