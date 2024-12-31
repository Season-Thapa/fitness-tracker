using Microsoft.AspNetCore.Mvc;
using Pri.Ee.Api.Dtos.Goal;
using Pri.Ee.Core.Dtos;
using Pri.Ee.Core.Entities;
using Pri.Ee.Core.Services.Interfaces;

namespace Pri.Ee.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoalsController : Controller
    {
        private readonly IGoalService _goalService;

        public GoalsController(IGoalService goalService)
        {
            _goalService = goalService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _goalService.GetAllGoalsAsync();
            if (result.Success)
            {
                var goalDtos = result.Data.Select(g => new GoalResponseDto
                {
                    Id = g.Id,
                    Target = g.Target,

                });
                return Ok(goalDtos);
            }
            return BadRequest(result.Errors);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _goalService.GetGoalByIdAsync(id);
            if (result.Success)
            {
                var goalDto = new GoalResponseDto
                {
                    Id = result.Data.Id,
                    Target = result.Data.Target,

                };
                return Ok(goalDto);
            }
            return BadRequest(result.Errors);
        }
        [HttpPost]
        public async Task<IActionResult> Add(GoalRequestDto goalDto)
        {
            var goal = new Goal
            {
                Id = goalDto.Id,
                Target = goalDto.Target,

            };
            var resultGoal = await _goalService.AddGoalAsync(goal);
            if (resultGoal.Success)
            {
                var dto = new GoalResponseDto
                {
                    Id = goal.Id,
                    Target = goal.Target,
                };
                return CreatedAtAction(nameof(Get), new { id = dto.Id, }, dto); 

            }
            return BadRequest(resultGoal.Errors);
        }
        [HttpPut]
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
        public async Task<IActionResult> UpdateGoalProgress(Guid id)
        {
            var result = await _goalService.UpdateGoalProgressAsync(id);
            if (result.Success == false)
            {
                return BadRequest("Unable to update goal progress");
            }

            return Ok("Goal progress updated successfully");
        }
    }
}
