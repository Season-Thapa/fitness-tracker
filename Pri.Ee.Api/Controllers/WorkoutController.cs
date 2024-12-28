using Microsoft.AspNetCore.Mvc;
using Pri.Ee.Api.Dtos.Workout;
using Pri.Ee.Core.Dtos;
using Pri.Ee.Core.Entities;
using Pri.Ee.Core.Services.Interfaces;

namespace Pri.Ee.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutController : ControllerBase
    {
        private readonly IWorkoutService _workoutService;

        public WorkoutController(IWorkoutService workoutService)
        {
            _workoutService = workoutService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _workoutService.GetAllWorkoutsAsync();
            if (result.Success)
            {
                var workoutDto = result.Data.Select(w => new WorkoutResponseDto
                {
                    Id = w.Id,
                    Type = w.Type,
                    CaloriesBurned = w.CaloriesBurned,
                    Date = w.Date,
                    Duration = w.Duration,

                });
                return Ok(workoutDto);
            }
            return BadRequest(result.Errors);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _workoutService.GetWorkoutByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            if (result.Success)
            {
                var workoutDto = new WorkoutResponseDto
                {
                    Id = result.Data.Id,
                    Type = result.Data.Type,
                    CaloriesBurned = result.Data.CaloriesBurned,
                    Date = result.Data.Date,
                    Duration = result.Data.Duration,

                };
                return Ok(workoutDto);
            }
            return BadRequest(result.Errors);
        }
        [HttpPost]
        public async Task<IActionResult> Add(WorkoutRequestDto workoutRequestDto)
        {
            var workout = new Workout
            {
                Type = workoutRequestDto.Type,
            };
            var resultWorkout = await _workoutService.AddWorkoutAsync(workout);
            if (resultWorkout.Success)
            {
                var dto = new WorkoutResponseDto
                {
                    Id = workout.Id,
                    Type = workout.Type,
                    Date = workout.Date,
                    Duration = workout.Duration,
                    CaloriesBurned = workout.CaloriesBurned                    
                };
                return CreatedAtAction(nameof(Get), new {id = workout.Id}, dto);

            }
            return BadRequest(resultWorkout.Errors);
        }
    }
}
