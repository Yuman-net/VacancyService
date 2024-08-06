using IdentityModel.Client;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace User.Contollers
{
    [Route("user")]
    public class UserController : Controller
    {
        private readonly IHttpClientFactory httpClientFactory;

        public UserController(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
        }

        [HttpGet("order")]
        public async Task<IActionResult> GetOrders()
        {
            var authClient = this.httpClientFactory.CreateClient();
            var discoveryDocument = await authClient.GetDiscoveryDocumentAsync("https://localhost:5207");

            var tokenResponse = await authClient.RequestClientCredentialsTokenAsync(
                new ClientCredentialsTokenRequest
                {
                    Address = discoveryDocument.TokenEndpoint,
                    ClientId = "client_id",
                    ClientSecret = "client_secret",
                    Scope = "OrderAPI"
                });


            // retrieve to Orders
            
            
            var ordersClient = this.httpClientFactory.CreateClient();

            ordersClient.SetBearerToken(tokenResponse.AccessToken);

            var response = await ordersClient.GetAsync("https://localhost:5064/Orders/order");

            if (!response.IsSuccessStatusCode)
            {
                ViewBag.Message = response.StatusCode.ToString();
                return View();
            }

            var result = response.Content.ReadAsStringAsync().Result;

            return Ok(result);
        }
    }
}
