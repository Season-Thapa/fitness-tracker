using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pri.Ee.Api.Dtos.Workout;
using Pri.Ee.Core.Dtos;
using Pri.Ee.Core.Entities;
using Pri.Ee.Core.Services.Interfaces;
using Pri.Ee.Core.Services.Models;
using System.Security.Claims;

namespace Pri.Ee.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class WorkoutController : ControllerBase
    {
        private readonly IWorkoutService _workoutService;
        public WorkoutController(IWorkoutService workoutService)
        {
            _workoutService = workoutService;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Customer")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _workoutService.GetAllWorkoutsAsync();
            if (result.Success)
            {
                var workoutDto = result.Data.Select(w => new WorkoutResponseDto
                {
                    Id = w.Id,
                    UserId = w.UserId,
                    Type = w.Type,
                    CaloriesBurned = w.CaloriesBurned,
                    Date = w.Date,
                    Duration = w.Duration
                });
                return Ok(workoutDto);
            }
            return BadRequest(result.Errors);
        }
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin,Customer")]
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
        [Authorize(Roles = "Admin,Customer")]
        public async Task<IActionResult> Add(WorkoutRequestDto workoutRequestDto)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userIdClaim))
            {
                return Unauthorized("User ID not found in claims.");
            }

            var userId = userIdClaim;
            var workout = new Workout
            {
                Type = workoutRequestDto.Type,
                UserId = userId,
            };
            var resultWorkout = await _workoutService.AddWorkoutAsync(workout);
            if (resultWorkout.Success)
            {
                var dto = new WorkoutResponseDto
                {
                    Id = new Guid(),
                    UserId  = userId,
                    Type = workout.Type,
                    Date = workout.Date,
                };
                return CreatedAtAction(nameof(Get), new {id = workout.Id}, dto);

            }
            return BadRequest(resultWorkout.Errors);
        }
        [HttpGet("user-workout")]
        public async Task<IActionResult> GetWorkoutsByUserId()
        {
            var userIdClaim = User.Claims.FirstOrDefault(claim => claim.Type.Equals(ClaimTypes.NameIdentifier))!.Value;
            if (string.IsNullOrEmpty(userIdClaim))
            {
                return Unauthorized("User ID not found in claims.");
            }
            var userId = userIdClaim;
            var userWorkout = await _workoutService.GetWorkoutsByUserIdAsync(userId);
            if (userWorkout == null || !userWorkout.Success)
            {
                return NotFound("No workout found for the user");
            }
            var wokoutDtos = userWorkout.Data.Select(w => new WorkoutResponseDto
            {
                Id = w.Id,
                CaloriesBurned = w.CaloriesBurned,
                Type = w.Type,
                Date = w.Date,
                Duration = w.Duration,
            });
            return Ok(wokoutDtos);

        }
        [HttpPut]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(WorkoutRequestDto workoutRequestDto)
        {
            if(await _workoutService.DoesWorkoutIdExistAsync(workoutRequestDto.Id) == false)
            {
                return BadRequest($"No workout with id '{workoutRequestDto.Id}' found");
            }
            var selectedWorkout = await _workoutService.GetWorkoutByIdAsync(workoutRequestDto.Id);
            if (selectedWorkout.Success == false)
            {
                return BadRequest(selectedWorkout.Errors);
            }
            var existingEntity = selectedWorkout.Data;
            existingEntity.Type = workoutRequestDto.Type;
            var result = await _workoutService.UpdateWorkoutAsync(existingEntity);
            if (result.Success)
            {
                return Ok($"Workout {existingEntity.Id} updated");
            }
            return BadRequest(result.Errors);

        }
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (await _workoutService.DoesWorkoutIdExistAsync(id) == false)
            {
                return NotFound($"No workout with id '{id}' found");
            }
            var selectedWorkout = await _workoutService.GetWorkoutByIdAsync(id);
            if (selectedWorkout.Success == false)
            {
                return BadRequest(selectedWorkout.Errors);
            }
            var result = await _workoutService.DeleteWorkoutAsync(selectedWorkout.Data);
            return Ok($"Workout {selectedWorkout.Data.Id} deleted");
        }
    }
}
