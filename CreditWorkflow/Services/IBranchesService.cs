namespace CreditWorkflow.Services
{
    public interface IBranchesService
    {

       // [Get("")]
       //  Task<HttpResponseMessage> GetBranchesAsync();


        [Get("/")]
         Task<ApiResponse<BranchListModel<List<BranchesResponseModel>>>>GetBranchesAsync();
        //Task<ApiResponse<TransactionResponseBaseModel<BranchesResponseModel>>> GetBranchesAsync();

    }
}
