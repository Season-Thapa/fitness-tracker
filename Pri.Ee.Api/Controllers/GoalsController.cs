using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pri.Ee.Api.Dtos.Goal;
using Pri.Ee.Core.Dtos;
using Pri.Ee.Core.Entities;
using Pri.Ee.Core.Services.Interfaces;
using System.Security.Claims;

namespace Pri.Ee.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class GoalsController : Controller
    {
        private readonly IGoalService _goalService;

        public GoalsController(IGoalService goalService)
        {
            _goalService = goalService;
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Get()
        {         
            var result = await _goalService.GetAllGoalsAsync();
            if (result.Success)
            {
                var goalDtos = result.Data.Select(g => new GoalResponseDto
                {
                    Id = g.Id,
                    UserId = g.UserId,
                    Target = g.Target,
                    Progress = g.Progress,

                });
                return Ok(goalDtos);
            }
            return BadRequest(result.Errors);
        }
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin,Customer")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _goalService.GetGoalByIdAsync(id);
            if (result.Success)
            {
                var goalDto = new GoalResponseDto
                {
                    Id = result.Data.Id,
                    Target = result.Data.Target,
                    Progress = result.Data.Progress

                };
                return Ok(goalDto);
            }
            return BadRequest(result.Errors);
        }
        [HttpPost]
        [Authorize(Roles = "Admin,Customer")]
        public async Task<IActionResult> Add(GoalRequestDto goalDto)
        {
            var userIdClaim = User.Claims.FirstOrDefault(claim => claim.Type.Equals(ClaimTypes.NameIdentifier))!.Value;
            if (string.IsNullOrEmpty(userIdClaim))
            {
                return Unauthorized("User ID not found in claims.");
            }

            var userId = userIdClaim;
            var goal = new Goal
            {
                Target = goalDto.Target,
                UserId = userId,
                StartDate = goalDto.StartDate,
                EndDate = goalDto.EndDate,
                Description = goalDto.Description,               


            };
            var resultGoal = await _goalService.AddGoalAsync(goal);
            if (resultGoal.Success)
            {
                var dto = new GoalResponseDto
                {
                    Id = new Guid(),
                    Target = goal.Target,                  
                };
                return CreatedAtAction(nameof(Get), new { id = dto.Id}, dto); 

            }
            return BadRequest(resultGoal.Errors);
        }
        [HttpPut]
        [Authorize(Roles = "Admin,Customer")]
        public async Task<IActionResult> Update(GoalRequestDto goalDto)
        {
            if (await _goalService.DoesGoalIdExistAsync(goalDto.Id) == false)
            {
                return BadRequest($"No goal with id '{goalDto.Id}' found");
            }
            var existingGoalResult = await _goalService.GetGoalByIdAsync(goalDto.Id);
            if (existingGoalResult.Success == false)
            {
                return BadRequest(existingGoalResult.Errors);
            }
            var exisitngEntity = existingGoalResult.Data;
            exisitngEntity.Id = goalDto.Id;
            exisitngEntity.Target = goalDto.Target;
            var result = await _goalService.UpdateGoalAsync(exisitngEntity);
            if (result.Success)
            {
                return Ok($"Goal {exisitngEntity.Id} updated");
            }
            return BadRequest(result.Errors);
        }
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin,Customer")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (await _goalService.DoesGoalIdExistAsync(id) == false)
            {
                return BadRequest($"No goal with id '{id}' found");
            }
            var existingGoalResult = await _goalService.GetGoalByIdAsync(id);
            if(existingGoalResult.Success == false)
            {
                return BadRequest(existingGoalResult.Errors);
            }
            var result = _goalService.DeleteGoalAsync(existingGoalResult.Data);
            return Ok($"Goal {existingGoalResult.Data.Id} deleted");

        }
        [HttpPost("{id}/update-progress")]
        [Authorize(Roles = "Admin,Customer")]
        public async Task<IActionResult> UpdateGoalProgress(Guid id, [FromBody] int progress)
        {
            var goalResult = await _goalService.GetGoalByIdAsync(id);
            if (goalResult.Success == false || goalResult.Data == null)
            {
                return NotFound("Goal not found.");
            }

            var goal = goalResult.Data;

            goal.Progress += progress;

            if (goal.Progress > goal.Target)
            {
                goal.Progress = goal.Target;
            }

            var updateResult = await _goalService.UpdateGoalAsync(goal);
            if (updateResult.Success)
            {
                return Ok(new
                {
                    GoalId = goal.Id,
                    UpdatedProgress = goal.Progress,                    
                });
            }

            return BadRequest("Failed to update goal progress.");
        }

        [HttpGet("user-goals")]
        public async Task<IActionResult> GetGoalsByUserId()
        {
            var userIdClaim = User.Claims.FirstOrDefault(claim => claim.Type.Equals(ClaimTypes.NameIdentifier))!.Value;
            if (string.IsNullOrEmpty(userIdClaim))
            {
                return Unauthorized("User ID not found in claims.");
            }

            var userId = userIdClaim;

            var userGoals = await _goalService.GetGoalsByUserIdAsync(userId);
            if (userGoals == null || !userGoals.Success)
            {
                return NotFound("No goals found for the user.");
            }

            var goalDtos = userGoals.Data.Select(g => new GoalResponseDto
            {
                Id = g.Id,
                UserId = userId,
                Target = g.Target,
                Progress = g.Progress
            });

            return Ok(goalDtos);
        }

    }
}
