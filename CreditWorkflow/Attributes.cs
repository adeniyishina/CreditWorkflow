using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;

namespace CreditWorkflow
{
    public class Attributes
    {
       

        [AttributeUsage(validOn: AttributeTargets.Class | AttributeTargets.Method)]
        public class ApiKeyAttribute : Attribute, IAsyncActionFilter
        {

            

            private const string APIKEYNAME = "ApiKey";
            public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
            {
                if (!context.HttpContext.Request.Headers.TryGetValue(APIKEYNAME, out var extractedApiKey))
                {
                    var val = context.HttpContext.Request.Headers.Values.AsQueryable();
                    var val_ = context.HttpContext.Request.ContentType;
                    context.Result = new ContentResult()
                    {
                        StatusCode = 401,
                        Content = "API Key was not provided"
                    };
                    return;
                }
                var appSettings = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();
                var apiKey = appSettings.GetValue<string>(APIKEYNAME);
                if (!apiKey.Equals(extractedApiKey))
                {
                    context.Result = new ContentResult()
                    {
                        StatusCode = 401,
                        Content = "API Key is not valid"
                    };
                    return;
                }
                await next();
            }
        }
    }
}
