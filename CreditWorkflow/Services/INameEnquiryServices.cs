namespace CreditWorkflow.Services
{
    public interface INameEnquiryServices
    {

        [Get("/{accountNumber}")]
      // Task<HttpResponseMessage> NameEnquiryAsync(string accountNumber);
     Task<ApiResponse<TransactionResponseBaseModel<NameEquiryResponsecs>>> NameEnquiryAsync(string accountNumber);

    }
}
