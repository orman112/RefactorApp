using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using RefactorApp.Data.Repositories;
using RefactorApp.Services;
using System;

namespace RefactorApp
{
    public static class GetComboFunction
    {
        [FunctionName("GetComboFunction")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] //TODO: HTTP method (access level and verb)
            HttpRequest req, //TODO: not used
            ILogger log)
        {
            var orderId = Guid.NewGuid();
            log.LogWarning("Getting all possible combos for this order"); //TODO: wrong log level and no identifier specified

            var comboRepository = new ComboRepository();
            var comboService = new ComboService();
            var combos = comboService.GetMashedPotatoesCombo();

            return new OkObjectResult($"Here are the possible orders for order Id {orderId}: {combos}"); //TODO: needs to be serialized into JSON and should only return object
        }
    }
}
