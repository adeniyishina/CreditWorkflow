namespace CreditWorkflow.Services

{
    public interface IOpenAccountServices
    {

        [Post("/")]
        // Task<ApiResponse<OpenAccountResponseModel>> PostOpenAccountAsync([Body] OpenAccountRequestModel model);
        Task<ApiResponse<BaseResponseAccountOpen<OpenAccountResponseModel>>> PostOpenAccountAsync([Body] OpenAccountRequestModel model);

    }

}

