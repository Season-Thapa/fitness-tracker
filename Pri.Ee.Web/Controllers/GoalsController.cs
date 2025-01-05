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
            var token = HttpContext.Session.GetString(Constants.TokenKey);
            if (string.IsNullOrEmpty(token))
            {
                TempData["ErrorMessage"] = "You are not logged in.";
                return RedirectToAction("Login", "Accounts");
            }

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

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
            var completedGoals = goals.Where(g => g.Progress >= g.Target).ToList();
            var inProgressGoals = goals.Where(g => g.Progress < g.Target).ToList();
            ViewBag.CompletedGoals = completedGoals;
            ViewBag.InProgressGoals = inProgressGoals;

            return View(goals);
        }
        [HttpGet]
        public IActionResult Add()
        {
            var goalRequestDto = new GoalRequestDto();
            goalRequestDto.StartDate = DateTime.Now;
            goalRequestDto.EndDate = DateTime.Now.AddDays(1);
            return View(goalRequestDto);
        }

        [HttpPost]
        public async Task<IActionResult> Add(GoalRequestDto goalRequestDto)
        {
            if(goalRequestDto.StartDate < DateTime.Today || goalRequestDto.EndDate < goalRequestDto.StartDate)
            {
                return View(goalRequestDto);
            }
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

            return RedirectToAction("UserGoals");
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            await SetBearerToken();
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
            await SetBearerToken();
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
            return RedirectToAction("UserGoals");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            await SetBearerToken();
            var response = await _httpClient.DeleteAsync($"api/Goals/{id}");
            if (!response.IsSuccessStatusCode)
            {
                ModelState.AddModelError(string.Empty, $"Failed to delete goal with ID {id}.");
            }
            return RedirectToAction("UserGoals");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProgress(Guid id, int progress)
        {
            await SetBearerToken();
            if (progress <= 0)
            {
                TempData["ErrorMessage"] = "Progress increment must be greater than 0.";
                return RedirectToAction("UserGoals");
            }
            var response = await _httpClient.PostAsJsonAsync($"api/Goals/{id}/update-progress", progress);
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                TempData["ErrorMessage"] = $"Failed to update goal progress: {error}";
                return RedirectToAction("UserGoals");
            }
            var result = await response.Content.ReadFromJsonAsync<UpdateProgressResponseDto>(); 
            if (result.IsGoalAchieved)
            {
                TempData["SuccessMessage"] = result.Message;
            }
            else
            {
                TempData["SuccessMessage"] = "Goal progress updated successfully.";
            }
            return RedirectToAction("UserGoals");
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
