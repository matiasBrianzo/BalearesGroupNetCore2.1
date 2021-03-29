using System.Buffers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace ServerApi.Helper
{
    public class SyncfusionJsonAttribute: ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            if (context.Result is ObjectResult objectResult)
            {
                objectResult.Formatters.Add(
                    new JsonOutputFormatter(
                        new JsonSerializerSettings(){ 
                            ContractResolver =new Newtonsoft.Json.Serialization.DefaultContractResolver()
                            },context.HttpContext.RequestServices.GetRequiredService<ArrayPool<char>>()));
            }
            base.OnResultExecuting(context);
        }
    }
}