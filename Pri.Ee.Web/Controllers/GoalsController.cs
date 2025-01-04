using Microsoft.AspNetCore.Mvc;
using Pri.Ee.Web.Dtos.Goal;
using System.Net.Http.Headers;

namespace Pri.Ee.Web.Controllers
{

    public class GoalsController : Controller
    {
        private readonly HttpClient _httpClient;

        public GoalsController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("DefaultClient");

        }

        public async Task<IActionResult> Index()
        {
            await SetBearerToken();

            var response = await _httpClient.GetAsync("api/Goals");
            if (!response.IsSuccessStatusCode)
            {
                ModelState.AddModelError(string.Empty, "Failed to load goals.");
                return View(Enumerable.Empty<GoalDto>());
            }

            var goals = await response.Content.ReadFromJsonAsync<IEnumerable<GoalDto>>();
            return View(goals);
        }
        [HttpGet]
        public async Task<IActionResult> UserGoals()
        {
            // Retrieve the JWT token from session
            var token = HttpContext.Session.GetString(Constants.TokenKey);
            if (string.IsNullOrEmpty(token))
            {
                TempData["ErrorMessage"] = "You are not logged in.";
                return RedirectToAction("Login", "Accounts");
            }

            // Attach the token to the Authorization header
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            // Call the API to get goals for the logged-in user
            var response = await _httpClient.GetAsync("api/Goals/user-goals");
            if (!response.IsSuccessStatusCode)
            {
                TempData["ErrorMessage"] = "Failed to fetch user goals.";
                return RedirectToAction("Index", "Home");
            }

            var goals = await response.Content.ReadFromJsonAsync<IEnumerable<GoalResponseDto>>();
            if (goals == null || !goals.Any())
            {
                TempData["InfoMessage"] = "No goals found.";
                return View(Enumerable.Empty<GoalResponseDto>()); // Pass an empty list
            }

            return View(goals);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(GoalRequestDto goalRequestDto)
        {
            await SetBearerToken();
            if (!ModelState.IsValid)
            {
                return View(goalRequestDto);
            }

            var response = await _httpClient.PostAsJsonAsync("api/Goals", goalRequestDto);
            if (!response.IsSuccessStatusCode)
            {
                ModelState.AddModelError(string.Empty, "Failed to create goal.");
                return View(goalRequestDto);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/Goals/{id}");
            if (!response.IsSuccessStatusCode)
            {
                return NotFound();
            }

            var goal = await response.Content.ReadFromJsonAsync<GoalRequestDto>();
            return View(goal);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Guid id, GoalRequestDto goalRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return View(goalRequestDto);
            }

            var response = await _httpClient.PutAsJsonAsync("api/Goals", goalRequestDto);
            if (!response.IsSuccessStatusCode)
            {
                ModelState.AddModelError(string.Empty, "Failed to update goal.");
                return View(goalRequestDto);
            }

            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/Goals/{id}");
            if (!response.IsSuccessStatusCode)
            {
                ModelState.AddModelError(string.Empty, $"Failed to delete goal with ID {id}.");
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProgress(Guid id, int progress)
        {
            if (progress <= 0)
            {
                TempData["ErrorMessage"] = "Progress increment must be greater than 0.";
                return RedirectToAction("Index");
            }

            // Send the progress increment directly to the API
            var response = await _httpClient.PostAsJsonAsync($"api/Goals/{id}/update-progress", progress);
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                TempData["ErrorMessage"] = $"Failed to update goal progress: {error}";
                return RedirectToAction("Index");
            }

            TempData["SuccessMessage"] = "Goal progress updated successfully.";
            return RedirectToAction("Index");
        }
        private async Task SetBearerToken()
        {
            var token = HttpContext.Session.GetString(Constants.TokenKey);
            if (string.IsNullOrEmpty(token))
            {
                ModelState.AddModelError(string.Empty, "User is not authenticated.");
              
            }

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }


        
    }
}
