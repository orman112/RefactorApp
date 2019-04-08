using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using RefactorApp.Services;
using RefactorApp.Data.Combos;
using RefactorApp.Data.Sides;
using RefactorApp.Data.Desserts;
using Newtonsoft.Json;
using RefactorApp.Data;

namespace RefactorApp
{
    public static class PlaceOrderFunction
    {
        [FunctionName("PlaceOrderFunction")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] HttpRequest request,
            ILogger log)
        {
            var orderId = Guid.NewGuid();
            log.LogInformation("Placing new order.");


            if (!request.IsJson())
            {
                return new UnsupportedMediaTypeResult();
            }

            var kidsMeal = new KidMealCombo(new FrenchFry(), new IceCream());
            var comboService = new ComboService();
            var newOrder = comboService.PlaceOrderAsync(kidsMeal);

            return new AcceptedResult(); //TODO: Should return 201 Created result
        }
    }
}
