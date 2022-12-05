namespace CreditWorkflow.Services
{
    public interface IRelatedAccountServices
    {
        [Get("/{accountNumber}")]

       //Task<HttpResponseMessage> CustomerDetailAsync(string accountNumber);
        Task<ApiResponse<BranchListModel<List<RelatedAccountcs>>>>CustomerDetailAsync(string accountNumber);



    }
}
