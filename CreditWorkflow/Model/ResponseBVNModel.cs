using Newtonsoft.Json;

namespace CreditWorkflow.Model
{
    public class ResponseBVNModel
    {

        [JsonProperty("phoneNumber1")]
        public string phoneNumber1 { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }

        [JsonProperty("gender")]
        public string gender { get; set; }

        [JsonProperty("phoneNumber2")]
        public string phoneNumber2 { get; set; }

        [JsonProperty("levelOfAccount")]
        public string levelOfAccount { get; set; }

        [JsonProperty("lgaOfOrigin")]
        public string lgaOfOrigin { get; set; }

        [JsonProperty("lgaOfResidence")]
        public string lgaOfResidence { get; set; }

        [JsonProperty("maritalStatus")]
        public string maritalStatus { get; set; }

        [JsonProperty("nin")]
        public string nin { get; set; }

        [JsonProperty("nameOnCard")]
        public string nameOnCard { get; set; }

        [JsonProperty("nationality")]
        public string nationality { get; set; }

        [JsonProperty("residentialAddress")]
        public string residentialAddress { get; set; }

        [JsonProperty("stateOfOrigin")]
        public string stateOfOrigin { get; set; }

        [JsonProperty("stateOfResidence")]
        public string stateOfResidence { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("watchListed")]
        public string watchListed { get; set; }

        [JsonProperty("base64Image")]
        public string base64Image { get; set; }

        [JsonProperty("responseCode")]
        public string responseCode { get; set; }

        [JsonProperty("bvn")]
        public string bvn { get; set; }

        [JsonProperty("firstName")]
        public string firstName { get; set; }

        [JsonProperty("middleName")]
        public string middleName { get; set; }

        [JsonProperty("lastName")]
        public string lastName { get; set; }

        [JsonProperty("dateOfBirth")]
        public string dateOfBirth { get; set; }

        [JsonProperty("phoneNumber")]
        public object phoneNumber { get; set; }

        [JsonProperty("registrationDate")]
        public string registrationDate { get; set; }

        [JsonProperty("enrollmentBank")]
        public string enrollmentBank { get; set; }

        [JsonProperty("enrollmentBranch")]
        public string enrollmentBranch { get; set; }

        public override string ToString()
        {
            return System.Text.Json.JsonSerializer.Serialize(this);
        }

    }
}
