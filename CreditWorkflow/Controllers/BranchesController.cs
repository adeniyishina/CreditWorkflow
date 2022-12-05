

using static CreditWorkflow.Attributes;

namespace CreditWorkflow.Controllers
{
   [ApiKeyAttribute()]
    [Route("api/[controller]")]
    [ApiController]
    public class BranchesController : Controller
    {
        private IConfiguration Configuration;
        private readonly IBranchesService accountService;
        private readonly ILogger<AuthenticationService> _logger;



        public BranchesController(IHttpClientFactory clientFactory,
            IConfiguration _configuration,
            IBranchesService accountService, ILogger<AuthenticationService> logger)
        {
           
            Configuration = _configuration;
            this.accountService = accountService;
            _logger = logger;
        }




       

            [HttpGet("GetBranches")]
        public async Task<IActionResult>GetBranches()

        {
            try
            {

                ////var response = await accountService.GetBranchesAsync();

               ////var content = await response.Content.ReadAsStringAsync();
               //////return Ok();
               ////return Ok(response.Content);


                var response = await accountService.GetBranchesAsync();

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
