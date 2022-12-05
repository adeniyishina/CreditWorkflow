using Newtonsoft.Json;

namespace CreditWorkflow.Model
{
    public class BaseResponseAccountOpen<T>
    {

        [JsonProperty("respMsg")]
        public string respMsg { get; set; }

        [JsonProperty("respCode")]
        public int respCode { get; set; }

        [JsonProperty("data")]
        public T data { get; set; }


        public override string ToString()
        {
            return System.Text.Json.JsonSerializer.Serialize(this);
        }
    }
   

}
