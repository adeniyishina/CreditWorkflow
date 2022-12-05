
using static CreditWorkflow.Attributes;

namespace CreditWorkflow.Controllers
{

    [ApiKeyAttribute()]
    [Route("api/[controller]")]
    [ApiController]

    public class AccountController : Controller
    {
        private IConfiguration Configuration;
        private readonly IAccountService accountService;
        private readonly ILogger<AuthenticationService> _logger;


        public AccountController(IHttpClientFactory clientFactory,
            IConfiguration _configuration,
            IAccountService accountService, ILogger<AuthenticationService> logger)
        {
          
            

            Configuration = _configuration;
            this.accountService = accountService;
            _logger = logger;
        }



        [HttpPost("AccountDebit")]
        public async Task<IActionResult>AccountDebit([FromBody] RequestDebit model)

        {
            try
            {

                var referenceId = "US" + DateTime.Now.ToString("yyyyMMddhhmmss");

                var postTransactionModel = new PostTransactionRequestModel
                {
                    Amount = model.Amount,
                    ApplyFee = model.ApplyFee,
                    ChequeNo = "",
                    Currency = "NGN",
                    DestinationAccount = model.DestinationAccount,
                    ExternalReference = referenceId,
                    Fees = model.Fees.Select(f =>
                        new Fee
                        {
                            Account = f.Account,
                            FeeOn = "SOURCE",
                            Amount = f.Amount,
                            Narration = f.Narration,
                            TrnCode = "122"
                        }
                    ).ToList(),
                    Narration = model.Narration,
                    TrnCode = "122",
                    NoOfDays = 0,
                    SourceAccount = model.SourceAccount,
                    TransType = "FT",
                    TransferReference = referenceId,
                };

               var response = await accountService.PostTransactionAsync(postTransactionModel);



                return Ok(response.Content);
                _logger.LogInformation(response.Content.ToString());


            }
            catch (Exception ex)
            {
                return StatusCode(500);


                _logger.LogError(ex, "");
            }




        }

     

    
        

    }

    

    

  

}
