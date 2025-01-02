using Microsoft.AspNetCore.Mvc;
using Pri.Ee.Web.Dtos.Workout;
using System.Net.Http;

namespace Pri.Ee.Web.Controllers
{
    public class WorkoutController : Controller
    {
        private readonly HttpClient _httpClient;

        public WorkoutController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("DefaultClient"); ;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
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
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(WorkoutRequestDto workoutRequestDto)
        {
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

            return RedirectToAction("Index");
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

            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/Workout/{id}");
            if (!response.IsSuccessStatusCode)
            {
                ModelState.AddModelError(string.Empty, $"Failed to delete workout with ID {id}.");
            }

            return RedirectToAction("Index");
        }
    }
}
