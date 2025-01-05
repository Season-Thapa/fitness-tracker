using Microsoft.AspNetCore.Mvc;
using Pri.Ee.Web.Dtos.Workout;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Pri.Ee.Web.Controllers
{
    public class WorkoutController : Controller
    {
        private readonly HttpClient _httpClient;

        public WorkoutController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("DefaultClient"); 
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            await SetBearerToken();
            var response = await _httpClient.GetAsync("api/Workout");
            if (!response.IsSuccessStatusCode)
            {
                ModelState.AddModelError(string.Empty, "Failed to load workouts.");
                return View(Enumerable.Empty<WorkoutDto>());
            }
            Console.WriteLine(response.Content.ToString());
            var workouts = await response.Content.ReadFromJsonAsync<IEnumerable<WorkoutDto>>();
            return View(workouts);
        }
        [HttpGet]
        public async Task<IActionResult> UserWorkouts()
        {
            await SetBearerToken();
            var response = await _httpClient.GetAsync("api/Workout/user-workout");
            if (!response.IsSuccessStatusCode)
            {
                TempData["ErrorMessage"] = "Failed to fetch user workouts.";
                return RedirectToAction("Index", "Home");
            }
            var workout = await response.Content.ReadFromJsonAsync<IEnumerable<WorkoutResponseDto>>();
            if (workout == null || !workout.Any())
            {
                TempData["InfoMessage"] = "No workout found.";
                return View(Enumerable.Empty<WorkoutResponseDto>()); 
            }

            return View(workout);

        }
        [HttpGet]
        public IActionResult Add()
        {
            var workoutRequestDto = new WorkoutRequestDto();
            workoutRequestDto.Date = DateTime.Now;
            return View(workoutRequestDto);
        }
        [HttpPost]
        public async Task<IActionResult> Add(WorkoutRequestDto workoutRequestDto)
        {
            if (workoutRequestDto.Date < DateTime.Now)
            {
                return View(workoutRequestDto);
            }
            await SetBearerToken();
            if (!ModelState.IsValid)
            {
                return View(workoutRequestDto);
            }

       
            var response = await _httpClient.PostAsJsonAsync("api/Workout", workoutRequestDto);
            if (!response.IsSuccessStatusCode)
            {
                ModelState.AddModelError(string.Empty, "Failed to create workout.");
                return View(workoutRequestDto);
            }

            return RedirectToAction("UserWorkouts");
        }
        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/Workout/{id}");
            if (!response.IsSuccessStatusCode)
            {
                return NotFound();
            }

            var workout = await response.Content.ReadFromJsonAsync<WorkoutRequestDto>();
            return View(workout);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Guid id, WorkoutRequestDto workoutRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return View(workoutRequestDto);
            }

            var response = await _httpClient.PutAsJsonAsync("api/Workout", workoutRequestDto);
            if (!response.IsSuccessStatusCode)
            {
                ModelState.AddModelError(string.Empty, "Failed to update workout.");
                return View(workoutRequestDto);
            }

            return RedirectToAction("UserWorkouts");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            await SetBearerToken();
            var response = await _httpClient.DeleteAsync($"api/Workout/{id}");
            if (!response.IsSuccessStatusCode)
            {
                ModelState.AddModelError(string.Empty, $"Failed to delete workout with ID {id}.");
            }

            return RedirectToAction("UserWorkouts");
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
