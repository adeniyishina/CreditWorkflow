using CreditWorkflow.Model;


namespace CreditWorkflow.Services
{
    public interface IBVNService
    {
        [Post("/")]
        Task<ApiResponse<BNVResponseCode<ResponseBVNModel>>> PostBVNAsync([Body] RequestBVNModel model);

    }
}
