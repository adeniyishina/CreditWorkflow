namespace CreditWorkflow.Model
{
    public class CustomerDetailAccountResponseModel
    {
           [JsonPropertyName("prefix")]
           public string prefix { get; set; }


          [JsonPropertyName("accountNumber")]
          public string accountNumber { get; set; }


          [JsonPropertyName("altAcNo")]
          public string altAcNo { get; set; }


        [JsonPropertyName("customerNo")]
        public string customerNo { get; set; }


        [JsonPropertyName("customerName")]
        public string customerName { get; set; }


        [JsonPropertyName("address")]
        public string address { get; set; }


        [JsonPropertyName("ccyCode")]
        public string ccyCode { get; set; }


        [JsonPropertyName("ccyName")]
        public string ccyName { get; set; }


        [JsonPropertyName("dateOfBirth")]
        public string dateOfBirth { get; set; }


        [JsonPropertyName("gender")]
        public string gender { get; set; }


        [JsonPropertyName("phoneNumber")]
        public string phoneNumber { get; set; }


        [JsonPropertyName("email")]
        public string email { get; set; }


        [JsonPropertyName("accountClassCode")]
        public string accountClassCode { get; set; }


        [JsonPropertyName("accountClassDescription")]
        public string accountClassDescription { get; set; }


        [JsonPropertyName("availableBalance")]
        public int availableBalance { get; set; }



        [JsonPropertyName("bookBalance")]
        public int bookBalance { get; set; }



        [JsonPropertyName("blockedAmount")]
        public double blockedAmount { get; set; }



        [JsonPropertyName("accountStatus")]
        public string accountStatus { get; set; }



        [JsonPropertyName("accountType")]
        public string accountType { get; set; }



        [JsonPropertyName("branchCode")]
        public string branchCode { get; set; }


        [JsonPropertyName("branchName")]
        public string branchName { get; set; }


        [JsonPropertyName("nationalityCode")]
        public string nationalityCode { get; set; }


        [JsonPropertyName("nationality")]
        public string nationality { get; set; }


        [JsonPropertyName("customerCategory")]
        public string customerCategory { get; set; }


        [JsonPropertyName("locationCode")]
        public string locationCode { get; set; }


        [JsonPropertyName("location")]
        public string location { get; set; }


        [JsonPropertyName("bvnNumber")]
        public int bvnNumber { get; set; }


        [JsonPropertyName("customerType")]
        public string customerType { get; set; }



        [JsonPropertyName("accountOpenedDate")]
        public string accountOpenedDate { get; set; }


        [JsonPropertyName("relationshipManagerCode")]
        public string relationshipManagerCode { get; set; }


        [JsonPropertyName("relationshipManagerName")]
        public string relationshipManagerName { get; set; }


        [JsonPropertyName("minor")]
        public bool minor { get; set; }

        public override string ToString()
        {
            return System.Text.Json.JsonSerializer.Serialize(this);
        }

    }
}
