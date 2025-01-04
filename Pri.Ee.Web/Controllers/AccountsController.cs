using Microsoft.AspNetCore.Mvc;
using Pri.Ee.Web.Dtos;
using System.Net.Http.Headers;
using System.Net.Http;

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
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Constants.TokenKey,result.Token);

            return RedirectToAction("Index","Home");
        }
        public IActionResult TestAuthentication()
        {
            if (User.Identity.IsAuthenticated)
            {
                return Content("Authenticated");
            }
            return Content("Not Authenticated");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserRequestDto registerUserRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return View(registerUserRequestDto);
            }

            var response = await _httpClient.PostAsJsonAsync("api/Accounts/register", registerUserRequestDto);

            if (!response.IsSuccessStatusCode)
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Error Response: " + errorMessage);

                ModelState.AddModelError(string.Empty, "Registration failed. Please try again.");
                return View(registerUserRequestDto);
            }

            // Registration successful, redirect to login page
            TempData["SuccessMessage"] = "Registration successful! Please log in.";
            return RedirectToAction("Login");
        }

    }
}
