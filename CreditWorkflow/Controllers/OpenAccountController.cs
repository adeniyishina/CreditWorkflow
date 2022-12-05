using Microsoft.AspNetCore.Mvc;
using CreditWorkflow.Services;
using static CreditWorkflow.Attributes;

namespace CreditWorkflow.Controllers
{
 //  [ApiKeyAttribute()]
    [Route("api/[controller]")]
    [ApiController]

    public class OpenAccountController : Controller
    {

        private IConfiguration Configuration;
        private readonly IOpenAccountServices accountService;
        private readonly IBVNService BVNService;
        private readonly ILogger<AuthenticationService> _logger;


        public OpenAccountController(IHttpClientFactory clientFactory,
            IConfiguration _configuration,
            IOpenAccountServices accountService, IBVNService BVNService,
            ILogger<AuthenticationService> logger)
        {

            Configuration = _configuration;
            this.accountService = accountService;
            this.BVNService = BVNService;
            _logger = logger;
        }



        [HttpPost("OpenAccount")]
        public async Task<IActionResult> OpenAccount([FromBody] OpenAcctRequest model)

        {
            try
            {
                
                var postBVNModel = new RequestBVNModel
                {

                    BVN = model.bvnNumber,

                };
                _logger.LogInformation(postBVNModel.ToString());

                var BVNresponse = await BVNService.PostBVNAsync(postBVNModel);

                _logger.LogInformation(BVNresponse.ToString());

                if (BVNresponse.IsSuccessStatusCode && BVNresponse.Content.Data.watchListed == "NO" && BVNresponse.Content.Data.phoneNumber == model.phoneNumber || BVNresponse.Content.Data.phoneNumber1 == model.phoneNumber || BVNresponse.Content.Data.phoneNumber2 == model.phoneNumber)
                {


                    //"2022-19-24T16:15:47.686Z",
                    string getCurrentDate = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.ssssZ");

                    var postTransactionModel = new OpenAccountRequestModel
                    {

                        accountCcy = "NGN",
                        accountClass = model.accountClass,
                        accountType = "I",
                        address = model.residentialAddress,
                        address2 = "",
                        address3 = "",
                        address4 = "",
                        branchCode = "000",
                        bvnNumber = BVNresponse.Content.Data.bvn, //model.bvnNumber,
                        country = "NGA",
                        customerCategory = model.customerCategory,
                        customerNo = model.customerNo,
                        dob = model.dateOfBirth, //"1971-10-24T16:15:47.685Z"

                        email = model.email,  //  exceptedSubmissionDate = getCurrentDate.ToString(),
                        exceptedSubmissionDate = "2023-06-29T16:15:47.686Z",
                        firstName = BVNresponse.Content.Data.firstName.ToLower(), //model.firstName.ToLower(),
                        gender = model.gender, //BVNresponse.Content.Data.gender,
                        guardian = "",
                        initMis = "444",
                        isAdditional = model.isAdditional,
                        isMinor = false,
                        isPND = true,
                        lastName = BVNresponse.Content.Data.lastName.ToLower(), //model.lastName.ToLower(),
                        location = "LAG",
                        maritalStatus = model.maritalStatus,
                        media = "MAIL",
                        motherMaidenName = "",
                        nationality = model.nationality,
                        officerMis = "",
                        otherNames = BVNresponse.Content.Data.middleName.ToLower(), //model.middleName.ToLower(),
                        phoneNumber = BVNresponse.Content.Data.phoneNumber1, //model.phoneNumber,
                        prefix = model.title,
                        referralCode = "",
                        productCode = "AGBK",

                    };
                    _logger.LogInformation(postTransactionModel.ToString());
                    var response = await accountService.PostOpenAccountAsync(postTransactionModel);

                    _logger.LogInformation(response.ToString());
                    return Ok(response.Content);

                }
                else
                
                {
                    return Ok("BVN / Phone  Number is not valid");
                }
             
            }
            catch (Exception ex)
            {
                return StatusCode(500);
                _logger.LogError(ex, "");
            }




        }



    }
}
