namespace CreditWorkflow.Model
{
    public class OpenAccountRequestModel
    {
        [JsonPropertyName("accountCcy")]
        public string accountCcy { get; set; }

        [JsonPropertyName("accountClass")]
        public string accountClass { get; set; }

        [JsonPropertyName("accountType")]
        public string accountType { get; set; }

        [JsonPropertyName("address")]
        public string address { get; set; }

        [JsonPropertyName("address2")]
        public string address2 { get; set; }

        [JsonPropertyName("address3")]
        public string address3 { get; set; }

        [JsonPropertyName("address4")]
        public string address4 { get; set; }

        [JsonPropertyName("branchCode")]
        public string branchCode { get; set; }

        [JsonPropertyName("bvnNumber")]
        public string bvnNumber { get; set; }

        [JsonPropertyName("country")]
        public string country { get; set; }

        [JsonPropertyName("customerCategory")]
        public string customerCategory { get; set; }

        [JsonPropertyName("customerNo")]
        public string customerNo { get; set; }

        [JsonPropertyName("dob")]
        public string dob { get; set; }

        [JsonPropertyName("email")]
        public string email { get; set; }

        [JsonPropertyName("exceptedSubmissionDate")]
        public string exceptedSubmissionDate { get; set; }

        [JsonPropertyName("firstName")]
        public string firstName { get; set; }

        [JsonPropertyName("gender")]
        public string gender { get; set; }

        [JsonPropertyName("guardian")]
        public string guardian { get; set; }

        [JsonPropertyName("initMis")]
        public string initMis { get; set; }

        [JsonPropertyName("isAdditional")]
        public bool isAdditional { get; set; }

        [JsonPropertyName("isMinor")]
        public bool isMinor { get; set; }

        [JsonPropertyName("isPND")]
        public bool isPND { get; set; }

        [JsonPropertyName("lastName")]
        public string lastName { get; set; }

        [JsonPropertyName("location")]
        public string location { get; set; }

        [JsonPropertyName("maritalStatus")]
        public string maritalStatus { get; set; }

        [JsonPropertyName("media")]
        public string media { get; set; }

        [JsonPropertyName("motherMaidenName")]
        public string motherMaidenName { get; set; }

        [JsonPropertyName("nationality")]
        public string nationality { get; set; }

        [JsonPropertyName("officerMis")]
        public string officerMis { get; set; }

        [JsonPropertyName("otherNames")]
        public string otherNames { get; set; }

        [JsonPropertyName("phoneNumber")]
        public string phoneNumber { get; set; }

        [JsonPropertyName("prefix")]
        public string prefix { get; set; }

        [JsonPropertyName("referralCode")]
        public string referralCode { get; set; }

        [JsonPropertyName("productCode")]
        public string productCode { get; set; }

        public override string ToString()
        {
            return System.Text.Json.JsonSerializer.Serialize(this);
        }
    }
}
