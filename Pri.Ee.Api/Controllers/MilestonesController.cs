using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pri.Ee.Api.Dtos.Milestone;
using Pri.Ee.Core.Entities;
using Pri.Ee.Core.Services.Interfaces;

namespace Pri.Ee.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MilestonesController : ControllerBase
    {
        private readonly IMilestoneService _milestoneService;

        public MilestonesController(IMilestoneService milestoneService)
        {
            _milestoneService = milestoneService;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Get()
        {
            var result = await _milestoneService.GetAllMilestonesAsync();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Errors);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin,Customer")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _milestoneService.GetMilestoneByIdAsync(id);
            if (result.Success)
            {
                var milestoneDto = new MilestoneDto
                {
                    Id = result.Data.Id,
                    Description = result.Data.Description,
                    Target = result.Data.Target,
                    GoalId = result.Data.GoalId,
                };
               
                return Ok(milestoneDto);
            }
            return BadRequest(result.Errors);
        }

       [HttpPost]
       [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Add(MilestoneDto milestoneDto)
        {
            var mileStone = new Milestone
            {
                Description = milestoneDto.Description,
                Target = milestoneDto.Target,
                GoalId = milestoneDto.GoalId,

            };
            var resultMilestone = await _milestoneService.AddMilestoneAsync(mileStone);
            if (resultMilestone.Success)
            {
                var dto = new MilestoneDto
                {
                    Id = new Guid(),
                    Target = mileStone.Target,
                    GoalId= milestoneDto.GoalId,
                };
                return CreatedAtAction(nameof(Get), new { id = dto.Id }, dto);
            }
            return BadRequest(resultMilestone.Errors);
        }

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(Milestone milestone)
        {
            var existingMilestoneResult = await _milestoneService.GetMilestoneByIdAsync(milestone.Id);
            if (existingMilestoneResult.Success == false)
            {
                return BadRequest(existingMilestoneResult.Errors);

            }
            var result = await _milestoneService.UpdateMilestoneAsync(milestone);
            var existingEntity = existingMilestoneResult.Data;
            existingEntity.GoalId = milestone.GoalId;
            existingEntity.Target = milestone.Target;
            existingEntity.Description = milestone.Description;
           
            if (result.Success)
            {
                return Ok($"Goal {existingEntity.Id} updated");
            }
            return BadRequest(result.Errors);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _milestoneService.DeleteMilestoneAsync(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Errors);
        }

    
        [HttpGet("{milestoneId}/sub-resources")]
        [Authorize(Roles = "Admin,Customer")]
        public async Task<IActionResult> GetSubResources(Guid milestoneId)
        {
            var result = await _milestoneService.GetSubResourcesAsync(milestoneId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Errors);
        }
    }
}
