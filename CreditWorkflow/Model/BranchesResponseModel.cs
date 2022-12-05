using static CreditWorkflow.Model.NameEquiryResponsecs;

namespace CreditWorkflow.Model
{
    public class BranchesResponseModel
    {
        



            [JsonPropertyName("branchName")]
            public string BranchName { get; set; }

            [JsonPropertyName("branchCode")]
            public string BranchCode { get; set; }

            [JsonPropertyName("address1")]
            public string Address1 { get; set; }

            [JsonPropertyName("address2")]
            public string Address2 { get; set; }

            [JsonPropertyName("address3")]
            public string Address3 { get; set; }

            [JsonPropertyName("swiftAddr")]
            public string SwiftAddr { get; set; }


        public override string ToString()
        {
            return System.Text.Json.JsonSerializer.Serialize(this);
        }

    }
}
