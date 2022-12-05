namespace CreditWorkflow.Model
{
    public class NameEquiryResponsecs
    {
        // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
        public class Data
        {
            [JsonPropertyName("prefix")]
            public string Prefix { get; set; }

            [JsonPropertyName("accountNumber")]
            public string AccountNumber { get; set; }

            [JsonPropertyName("altAcNo")]
            public string AltAcNo { get; set; }

            [JsonPropertyName("customerNo")]
            public string CustomerNo { get; set; }

            [JsonPropertyName("customerName")]
            public string CustomerName { get; set; }

            [JsonPropertyName("address")]
            public object Address { get; set; }

            [JsonPropertyName("ccyCode")]
            public string CcyCode { get; set; }

            [JsonPropertyName("ccyName")]
            public string CcyName { get; set; }

            [JsonPropertyName("dateOfBirth")]
            public string DateOfBirth { get; set; }

            [JsonPropertyName("gender")]
            public object Gender { get; set; }

            [JsonPropertyName("phoneNumber")]
            public string PhoneNumber { get; set; }

            [JsonPropertyName("email")]
            public string Email { get; set; }

            [JsonPropertyName("accountClassCode")]
            public string AccountClassCode { get; set; }

            [JsonPropertyName("accountClassDescription")]
            public string AccountClassDescription { get; set; }

            [JsonPropertyName("availableBalance")]
            public double AvailableBalance { get; set; }

            [JsonPropertyName("bookBalance")]
            public double BookBalance { get; set; }

            [JsonPropertyName("blockedAmount")]
            public double BlockedAmount { get; set; }

            [JsonPropertyName("accountStatus")]
            public string AccountStatus { get; set; }

            [JsonPropertyName("accountType")]
            public string AccountType { get; set; }

            [JsonPropertyName("branchCode")]
            public string BranchCode { get; set; }

            [JsonPropertyName("branchName")]
            public string BranchName { get; set; }

            [JsonPropertyName("nationalityCode")]
            public string NationalityCode { get; set; }

            [JsonPropertyName("nationality")]
            public string Nationality { get; set; }

            [JsonPropertyName("customerCategory")]
            public string CustomerCategory { get; set; }

            [JsonPropertyName("locationCode")]
            public string LocationCode { get; set; }

            [JsonPropertyName("location")]
            public string Location { get; set; }

            [JsonPropertyName("bvnNumber")]
            public string BvnNumber { get; set; }

            [JsonPropertyName("customerType")]
            public string CustomerType { get; set; }

            [JsonPropertyName("accountOpenedDate")]
            public string AccountOpenedDate { get; set; }

            [JsonPropertyName("relationshipManagerCode")]
            public object RelationshipManagerCode { get; set; }

            [JsonPropertyName("relationshipManagerName")]
            public object RelationshipManagerName { get; set; }

            [JsonPropertyName("introducerMis")]
            public object IntroducerMis { get; set; }

            [JsonPropertyName("accMis")]
            public object AccMis { get; set; }

            [JsonPropertyName("defaultMedia")]
            public string DefaultMedia { get; set; }

            [JsonPropertyName("country")]
            public string Country { get; set; }

            [JsonPropertyName("jointAcIndicator")]
            public string JointAcIndicator { get; set; }

            [JsonPropertyName("mandateAuthority")]
            public object MandateAuthority { get; set; }

            [JsonPropertyName("minor")]
            public bool Minor { get; set; }

            public override string ToString()
            {
                return System.Text.Json.JsonSerializer.Serialize(this);
            }
        }

        ////public class Root
        ////{
        ////    [JsonPropertyName("respMsg")]
        ////    public string RespMsg { get; set; }

        ////    [JsonPropertyName("respCode")]
        ////    public int RespCode { get; set; }

        ////    [JsonPropertyName("data")]
        ////    public Data Data { get; set; }
        ////}



    }
}
