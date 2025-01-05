using Microsoft.AspNetCore.Mvc;
using Pri.Ee.Web.Dtos.Goal;
using Pri.Ee.Web.Dtos.Milestone;
using System.Net.Http.Headers;
using System.Text.Json;

namespace Pri.Ee.Web.Controllers
{
    public class MilestonesController : Controller
    {
        private readonly HttpClient _httpClient;

        public MilestonesController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("DefaultClient");
        }
        public async Task<IActionResult> Index()
        {
            await SetBearerToken();

            var response = await _httpClient.GetAsync("api/Milestones");
            if (!response.IsSuccessStatusCode)
            {
                TempData["ErrorMessage"] = "Failed to load milestones.";
                return View(Enumerable.Empty<MilestoneDto>());
            }

            var milestones = await response.Content.ReadFromJsonAsync<IEnumerable<MilestoneDto>>();
            return View(milestones);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            await SetBearerToken();

            var response = await _httpClient.GetAsync($"api/Milestones/{id}");
            if (!response.IsSuccessStatusCode)
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                TempData["ErrorMessage"] = $"Failed to load milestone details. Error: {errorMessage}";
                return RedirectToAction("Index");
            }

            try
            {
                var milestone = await response.Content.ReadFromJsonAsync<MilestoneDto>();
                return View(milestone);
            }
            catch (JsonException ex)
            {
                TempData["ErrorMessage"] = $"Failed to parse milestone details. Error: {ex.Message}";
                return RedirectToAction("Index");
            }
        }


        public async Task<IActionResult> Add()
        {
            await SetBearerToken();

            var response = await _httpClient.GetAsync("api/Goals");
            if (!response.IsSuccessStatusCode)
            {
                TempData["ErrorMessage"] = "Failed to load goals.";
                return RedirectToAction("Index");
            }

            // Deserialize the list of goals
            var goals = await response.Content.ReadFromJsonAsync<IEnumerable<GoalDto>>();

            // Pass the goals to the view using ViewBag
            ViewBag.Goals = goals;
            var milestoneDto = new MilestoneDto();
            return View(milestoneDto);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(MilestoneDto milestoneDto)
        {
            await SetBearerToken();
            if (ModelState.IsValid)
            {
                var response = await _httpClient.PostAsJsonAsync("api/Milestones", milestoneDto);
                if (!response.IsSuccessStatusCode)
                {
                    TempData["ErrorMessage"] = "Failed to create milestone.";
                    return View(milestoneDto);
                }

                TempData["SuccessMessage"] = "Milestone created successfully!";
                return RedirectToAction("Index");
            }


            return View(milestoneDto);

        }
        // GET: /Milestones/Edit/{id}
        public async Task<IActionResult> Update(Guid id)
        {
            await SetBearerToken();
            var response = await _httpClient.GetAsync($"api/Milestones/{id}");
            if (!response.IsSuccessStatusCode)
            {
                TempData["ErrorMessage"] = "Failed to load milestone details for editing.";
                return RedirectToAction("Index");
            }

            var milestone = await response.Content.ReadFromJsonAsync<MilestoneDto>();
            return View(milestone);
        }

        // POST: /Milestones/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Guid id, MilestoneDto milestoneDto)
        {
            await SetBearerToken();

            if (ModelState.IsValid)
            {
                var response = await _httpClient.PutAsJsonAsync($"api/Milestones/{id}", milestoneDto);
                if (!response.IsSuccessStatusCode)
                {
                    TempData["ErrorMessage"] = "Failed to update milestone.";
                    return View(milestoneDto);
                }

                TempData["SuccessMessage"] = "Milestone updated successfully!";
                return RedirectToAction("Index");
            }

            return View(milestoneDto);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/Milestones/{id}");
            if (!response.IsSuccessStatusCode)
            {
                TempData["ErrorMessage"] = "Failed to load milestone for deletion.";
                return RedirectToAction("Index");
            }

            var milestone = await response.Content.ReadFromJsonAsync<MilestoneDto>();
            return View(milestone);
        }


        
        private async Task SetBearerToken()
        {
            var token = HttpContext.Session.GetString(Constants.TokenKey);
            if (string.IsNullOrEmpty(token))
            {
                ModelState.AddModelError(string.Empty, "User is not authenticated.");
                return; // Exit early if the token is missing
            }

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }
    }
}
