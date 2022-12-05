using System.Net.Http.Headers;
using CreditWorkflow;
using System.Text;
using CreditWorkflow.Services;
using Serilog;
using CreditWorkflow.Services;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors(options =>
{
    options.AddPolicy(MyAllowSpecificOrigins,
                          policy =>
                          {
                              policy.AllowAnyOrigin()
                                                  .AllowAnyHeader()
                                                  .AllowAnyMethod();
                          });
});

builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.All;
    logging.RequestBodyLogLimit = 4096;
    logging.ResponseBodyLogLimit = 4096;
});


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var configuration = builder.Configuration;
builder.Services.AddLogging(builder =>
{
    builder.AddConfiguration(configuration.GetSection("Logging"))
      .AddSerilog(new LoggerConfiguration().WriteTo.File("Log/log.txt").CreateLogger())
      .AddConsole();
#if DEBUG
    builder.AddDebug();
#endif
});



//Not valid SSL
var httpClienttransaction = new HttpClient(new HttpClientHandler { ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; } })
{
    BaseAddress = new Uri(builder.Configuration["CoreBanking:transactionUrl"]),
     
     
};

httpClienttransaction.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", builder.Configuration["CoreBanking:accessToken"]);
builder.Services.AddHttpClient("transactionService").AddTypedClient(r => RestService.For<IAccountService>(httpClienttransaction));


//use to get IBranchesService
var httpClientNameEnquiry = new HttpClient(new HttpClientHandler { ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; } })
{
    BaseAddress = new Uri(builder.Configuration["CoreBanking:NameEnquiryUrl"])
};

httpClientNameEnquiry.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", builder.Configuration["CoreBanking:accessToken"]);
builder.Services.AddHttpClient("transactionService").AddTypedClient(r => RestService.For<INameEnquiryServices>(httpClientNameEnquiry));


//use to get another service
var httpClientRelatedAccount = new HttpClient(new HttpClientHandler { ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; } })
{
    BaseAddress = new Uri(builder.Configuration["CoreBanking:RelatedAccountUrl"])
};

httpClientRelatedAccount.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", builder.Configuration["CoreBanking:accessToken"]);
builder.Services.AddHttpClient("transactionService").AddTypedClient(r => RestService.For<IRelatedAccountServices>(httpClientRelatedAccount));


//use to get another service
var httpClientBranches = new HttpClient(new HttpClientHandler { ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; } })
{
    BaseAddress = new Uri(builder.Configuration["CoreBanking:GetBranchesUrl"])
};

httpClientBranches.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", builder.Configuration["CoreBanking:accessToken"]);
builder.Services.AddHttpClient("transactionService").AddTypedClient(r => RestService.For<IBranchesService>(httpClientBranches));


// Not valid SSL
var httpClientOpenAccount = new HttpClient(new HttpClientHandler { ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; } })
{
    BaseAddress = new Uri(builder.Configuration["CoreBanking:OpenAccountUrl"])
};

httpClientOpenAccount.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", builder.Configuration["CoreBanking:accessToken"]);
builder.Services.AddHttpClient("transactionService").AddTypedClient(r => RestService.For<IOpenAccountServices>(httpClientOpenAccount));


// Not valid SSL
var httpClientBVN = new HttpClient(new HttpClientHandler { ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; } })
{
    BaseAddress = new Uri(builder.Configuration["CoreBanking:BVNUrl"])
};

httpClientBVN.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", builder.Configuration["CoreBanking:BVNaccessToken"]);
builder.Services.AddHttpClient("transactionService").AddTypedClient(r => RestService.For<IBVNService>(httpClientBVN));






// valid SSL
//builder.Services.AddRefitClient<IAccountService>()    
//    .ConfigureHttpClient(c =>
//    { 

//        c.BaseAddress = new Uri(builder.Configuration["CoreBanking:baseUrl"]);
//        c.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", builder.Configuration["CoreBanking:accessToken"]);
//    });




var app = builder.Build();
app.UseHttpLogging();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
     //app.UseSwagger();
     //app.UseSwaggerUI();
}

app.UseSwagger();
app.UseHttpsRedirection();
app.UseSwaggerUI(c =>

{

    c.SwaggerEndpoint("/swagger/v1/swagger.json", "PremiumTrust Bank API");

});
app.UseRouting();

app.UseCors(MyAllowSpecificOrigins);
app.UseAuthorization();

app.MapControllers();

app.Run();


//// string clientid = "cbb780b8-e52f-4e36-b8ad-5c6bffba147a";
//// string clientSecret = "9JHGyfskxRW+VEcXsRH5D4jDSKm2uDa9iCc4uSSNF78=";
////static void Test()
////{
////    string content = "this is a test";
////    string contentMD5 = Security.CreateContentMd5Hash(Encoding.UTF8.GetBytes(content));
////    string messageRepresentation = string.Join("\n", "post", contentMD5, DateTime.UtcNow.ToString("o"), clientid.ToLower());
////    string authorization = Security.RequestSignature(clientSecret, messageRepresentation);

//// }
