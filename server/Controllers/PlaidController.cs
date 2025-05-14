using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Text;

namespace BudgetApp_MVP.Controllers
{
    [ApiController]
    [Route("api/plaid")]
    public class PlaidController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _httpClientFactory;

        public PlaidController(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        // Exchanges a Plaid public token for an access token
        [HttpPost("exchange")]
        public async Task<IActionResult> ExchangeToken([FromBody] PlaidTokenRequest request)
        {
            var client = _httpClientFactory.CreateClient();

            var plaidClientId = _configuration["Plaid:ClientId"];
            var plaidSecret = _configuration["Plaid:Secret"];
            var plaidEnv = _configuration["Plaid:Environment"];

            var payload = new
            {
                client_id = plaidClientId,
                secret = plaidSecret,
                public_token = request.PublicToken
            };

            var content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");

            // Call Plaid endpoint for token exchange
            var response = await client.PostAsync($"https://{plaidEnv}.plaid.com/item/public_token/exchange", content);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            // In a real implementation, you should parse and persist the access token
            return Ok(jsonResponse);
        }
    }

    public class PlaidTokenRequest
    {
        public string PublicToken { get; set; }
    }
}