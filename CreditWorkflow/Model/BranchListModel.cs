namespace CreditWorkflow.Model
{
    public class BranchListModel<T>
    {

        [JsonPropertyName("respMsg")]
        public string RespMsg { get; set; }

        [JsonPropertyName("respCode")]
        public int RespCode { get; set; }

        [JsonPropertyName("data")]
        public T Data { get; set; }

        public override string ToString()
        {
            return System.Text.Json.JsonSerializer.Serialize(this);
        }

    }
}
