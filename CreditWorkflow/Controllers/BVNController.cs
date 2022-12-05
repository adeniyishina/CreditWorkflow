using Microsoft.AspNetCore.Mvc;
using CreditWorkflow.Services;
using static CreditWorkflow.Attributes;

namespace USSDWebAPI.Controllers
{
    [ApiKeyAttribute()]
    [Route("api/[controller]")]
    [ApiController]

    public class BVNController : Controller
    {

        private IConfiguration Configuration;
        private readonly IBVNService BVNService;
        private readonly ILogger<AuthenticationService> _logger;


        public BVNController(IHttpClientFactory clientFactory,
            IConfiguration _configuration,
            IBVNService BVNService, ILogger<AuthenticationService> logger)
        {

            Configuration = _configuration;
            this.BVNService = BVNService;
            _logger = logger;
        }



        [HttpPost("VerifySingleBVN")]
        public async Task<IActionResult> VerifySingleBVN([FromBody] RequestBVNModel model)
        {
            try
            {

                var postTransactionModel = new RequestBVNModel
                {
                    BVN = model.BVN,

                };

                _logger.LogInformation(postTransactionModel.ToString());
                var response = await BVNService.PostBVNAsync(postTransactionModel);
                _logger.LogInformation(response.ToString());
                return Ok(response.Content);

            }
            catch (Exception ex)
            {
                return StatusCode(500);
                _logger.LogError(ex, "");
            }




        }



    }

}
