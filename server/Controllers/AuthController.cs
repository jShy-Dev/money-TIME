using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace BudgetApp_MVP.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        [HttpGet("google")]
        public IActionResult GoogleLogin()
        {
            var redirectUrl = Url.Action("GoogleResponse", "Auth");
            var properties = new AuthenticationProperties { RedirectUri = redirectUrl };
            return Challenge(properties, "Google");
        }

        [HttpGet("google/callback")]
        public IActionResult GoogleResponse()
        {
            // Handle Google OAuth callback logic here.
            return Redirect("/"); // Redirect to home after successful login
        }

        [HttpGet("microsoft")]
        public IActionResult MicrosoftLogin()
        {
            var redirectUrl = Url.Action("MicrosoftResponse", "Auth");
            var properties = new AuthenticationProperties { RedirectUri = redirectUrl };
            return Challenge(properties, "Microsoft");
        }

        [HttpGet("microsoft/callback")]
        public IActionResult MicrosoftResponse()
        {
            // Process Microsoft OAuth callback.
            return Redirect("/");
        }

        [HttpGet("apple")]
        public IActionResult AppleLogin()
        {
            // Apple OAuth integration requires custom configuration.
            return Redirect("/");
        }
    }
}