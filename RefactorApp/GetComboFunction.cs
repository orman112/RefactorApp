using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using RefactorApp.Data.Repositories;
using RefactorApp.Services;

namespace RefactorApp
{
    public static class GetComboFunction
    {
        [FunctionName("GetComboFunction")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] //HTTP method (access level and verb)
            HttpRequest req, //not used
            ILogger log)
        {
            log.LogWarning("C# HTTP trigger function processed a request."); //wrong log level

            var comboRepository = new ComboRepository();
            var comboService = new ComboService();
            var combos = comboService.GetMashedPotatoesCombo();

                       
            return new OkObjectResult($"Hello, {combos}");
        }
    }
}
