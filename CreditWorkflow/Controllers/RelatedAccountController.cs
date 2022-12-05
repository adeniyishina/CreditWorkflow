

using static CreditWorkflow.Attributes;

namespace CreditWorkflow.Controllers
{
    [ApiKeyAttribute()]
    [Route("api/[controller]")]
    [ApiController]
    public class RelatedAccountController : Controller
    {

        private IConfiguration Configuration;
        private readonly IRelatedAccountServices accountService;
        private readonly ILogger<AuthenticationService> _logger;




        public RelatedAccountController(IHttpClientFactory clientFactory,
            IConfiguration _configuration,
            IRelatedAccountServices accountService, ILogger<AuthenticationService> logger)
        {
          

            Configuration = _configuration;
            this.accountService = accountService;
            _logger = logger;
        }




        [ApiKeyAttribute()]
        [HttpPost("RelatedAccount")]
        public async Task<IActionResult>RelatedAccount(string CustomerID)

        {

    
            try
            {



                //var response = await accountService.CustomerDetailAsync(AccountyNumber);

                //var content = await response.Content.ReadAsStringAsync();

                //return Ok(response.Content);

                var response = await accountService.CustomerDetailAsync(CustomerID);

                return Ok(response.Content);
                _logger.LogInformation(response.Content.ToString());


                ////string baseAddress = "https://localhost:7206";
                ////using (var client = new HttpClient())
                ////{
                ////    var form = new Dictionary<string, string>
                ////{
                ////    {"grant_type", "USSDaCCESS"},
                ////    {"username", "Adeshina"},
                ////    {"password", "password"},
                ////};
                ////    var tokenResponse = client.PostAsync(baseAddress + "/oauth/token", new FormUrlEncodedContent(form)).Result;
                ////    var token = tokenResponse.Content.ReadAsStringAsync().Result;

                ////}

                // return null;

            }
            catch (Exception ex)
            {
                return StatusCode(500);
                _logger.LogError(ex, "");
            }




        }


    }
}
