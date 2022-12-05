

using static CreditWorkflow.Attributes;

namespace CreditWorkflow.Controllers
{

  [ApiKeyAttribute()]
    [Route("api/[controller]")]
    [ApiController]
    public class NameEnquiryController : Controller
    {

        private IConfiguration Configuration;
        private readonly INameEnquiryServices accountService;
        private readonly ILogger<AuthenticationService> _logger;

        ///  private readonly HttpClient _httpClient;
        //private readonly HttpClient AirTimehttpClient;

        //    public string _remoteServiceBaseUrl;

        public NameEnquiryController(IHttpClientFactory clientFactory,
            IConfiguration _configuration,
            INameEnquiryServices accountService, ILogger<AuthenticationService> logger)
        {
            ///  _httpClient = clientFactory.CreateClient("corebanking");



            Configuration = _configuration;
            this.accountService = accountService;
            _logger = logger;
        }


        [HttpGet("NameEnquiry")]
        public async Task<IActionResult>NameEnquiry(string accountNumber)

        {
            try
            {

        
                var response = await accountService.NameEnquiryAsync(accountNumber);

                return Ok(response.Content);
                _logger.LogInformation(response.Content.ToString());

            }
            catch (Exception ex)
            {
                return StatusCode(500);
                _logger.LogError(ex, "");
            }




        }





        //////[HttpGet("NameEnquiry")]
        //////public async Task<IActionResult> NameEnquiry(string accountNumber)

        //////{
        //////    try
        //////    {




        //////        var response = await accountService.NameEnquiryAsync(accountNumber);

        //////        var content = await response.Content.ReadAsStringAsync();
        //////        //return Ok();
        //////        return Ok(response.Content);
        //////        _logger.LogInformation(response.Content.ToString());

        //////    }
        //////    catch (Exception ex)
        //////    {
        //////        return StatusCode(500);
        //////        _logger.LogInformation("-----------------" + DateTime.Now + "-----------------\nsource:" + ex.Source + "\n stack trace" + ex.StackTrace + "\n-----------------");

        //////    }




        //////}

   
    
    }



}
