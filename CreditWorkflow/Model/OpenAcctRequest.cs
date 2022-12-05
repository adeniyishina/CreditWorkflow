namespace CreditWorkflow.Model
{
    public class OpenAcctRequest
    {


        [JsonPropertyName("bvnNumber")]
        public string bvnNumber { get; set; }

        [JsonPropertyName("firstName")]
        public string firstName { get; set; }

        [JsonPropertyName("middleName")]
        public string middleName { get; set; }

        [JsonPropertyName("lastName")]
        public string lastName { get; set; }

        [JsonPropertyName("dateOfBirth")]
        public string dateOfBirth { get; set; }


        [JsonPropertyName("phoneNumber")]
        public string phoneNumber { get; set; }


        [JsonPropertyName("accountClass")]
        public string accountClass { get; set; }

        [JsonPropertyName("customerCategory")]
        public string customerCategory { get; set; }


        [JsonPropertyName("email")]
        public string email { get; set; }


        [JsonPropertyName("gender")]
        public string gender { get; set; }


        [JsonPropertyName("residentialAddress")]
        public string residentialAddress { get; set; }


        [JsonPropertyName("title")]
        public string title { get; set; }


        [JsonPropertyName("nationality")]
        public string nationality { get; set; }

        [JsonPropertyName("maritalStatus")]
        public string maritalStatus { get; set; }

        [JsonPropertyName("customerNo")]
        public string customerNo { get; set; }

        [JsonPropertyName("isAdditional")]
        public bool isAdditional { get; set; }


        public override string ToString()
        {
            return System.Text.Json.JsonSerializer.Serialize(this);
        }

    }
}
