namespace CreditWorkflow.Model
{
   
        public class BNVResponseCode<T>
        {
            [JsonPropertyName("status")]
            public bool status { get; set; }

            [JsonPropertyName("message")]
            public string message { get; set; }

            [JsonPropertyName("data")]
            public T Data { get; set; }

            [JsonPropertyName("code")]
            public string code { get; set; }

        public override string ToString()
        {
            return System.Text.Json.JsonSerializer.Serialize(this);
        }
    }
    
}
