



using CreditWorkflow.Model;

namespace CreditWorkflow.Services
{
    public interface IAccountService
    {

        [Post("/")]
        Task<ApiResponse<TransactionResponseBaseModel<PostTransactionResponseModel>>>PostTransactionAsync([Body] PostTransactionRequestModel model);
        

       

       
      



    }


}
