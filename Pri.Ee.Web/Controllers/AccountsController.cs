using Microsoft.AspNetCore.Mvc;
using Pri.Ee.Web.Dtos;

namespace Pri.Ee.Web.Controllers
{
    public class AccountsController : Controller
    {
        private readonly HttpClient _httpClient;
        public AccountsController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("DefaultClient");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginUserRequestDto loginUserRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return View(loginUserRequestDto);
            }
            var response = await _httpClient.PostAsJsonAsync("api/Accounts/login", loginUserRequestDto); 

            if (!response.IsSuccessStatusCode)
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return View(loginUserRequestDto);
            }

            if (response.Content.Headers.ContentLength == 0)
            {
                ModelState.AddModelError(string.Empty, "Unexpected response from the server.");
                return View(loginUserRequestDto);
            }

            var result = await response.Content.ReadFromJsonAsync<LoginUserResponseDto>();
            if (result == null || string.IsNullOrEmpty(result.Token))
            {
                ModelState.AddModelError(string.Empty, "Invalid server response.");
                return View(loginUserRequestDto);
            }
            // Store JWT token in Session
            HttpContext.Session.SetString(Constants.TokenKey, result.Token);

            return RedirectToAction("Index", "Home");
        }
    }
}
