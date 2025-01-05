using Microsoft.EntityFrameworkCore;
using Pri.Ee.Core.Data;
using Pri.Ee.Core.Entities;
using Pri.Ee.Core.Services.Interfaces;
using Pri.Ee.Core.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Ee.Core.Services
{
    public class MilesStoneService : IMilestoneService
    {
        private readonly ApplicationDbContext _context;

        public MilesStoneService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<ResultModel<Milestone>> AddMilestoneAsync(Milestone milestone)
        {
            try
            {
                var goal = await _context.Goals.FindAsync(milestone.GoalId);
                if (goal == null)
                {
                    return new ResultModel<Milestone>
                    {
                        Errors = new List<string> { "Goal not found." }
                    };
                }
                await _context.Milestones.AddAsync(milestone);
                await _context.SaveChangesAsync();

                return new ResultModel<Milestone>
                {
                    Data = milestone
                };
            }
            catch (Exception ex)
            {
                return new ResultModel<Milestone>
                {
                    Errors = new List<string> { ex.Message }
                };
            }
        }

        public async Task<ResultModel<Milestone>> DeleteMilestoneAsync(Guid milestoneId)
        {
            try
            {
                var milestone = await _context.Milestones
                    .Where(m => m.Id == milestoneId)
                    .FirstOrDefaultAsync();

                if (milestone == null)
                {
                    return new ResultModel<Milestone>
                    {
                        Errors = new List<string> { "Milestone not found" }
                    };
                }

                _context.Milestones.Remove(milestone);
                await _context.SaveChangesAsync();

                return new ResultModel<Milestone>
                {
                    Data = milestone
                };
            }
            catch (Exception ex)
            {
                return new ResultModel<Milestone>
                {
                    Errors = new List<string> { ex.Message }
                };
            }
        }

        public async Task<ResultModel<IEnumerable<Milestone>>> GetAllMilestonesAsync()
        {
            try
            {
                var milestones = await _context.Milestones.ToListAsync();
                return new ResultModel<IEnumerable<Milestone>>
                {
                    Data = milestones
                };
            }
            catch (Exception ex)
            {
                return new ResultModel<IEnumerable<Milestone>>
                {
                    Errors = new List<string> { ex.Message }
                };
            }
        }

        public async Task<ResultModel<Milestone>> GetMilestoneByIdAsync(Guid id)
        {
            try
            {
                var milestone = await _context.Milestones
                    .Include(m => m.Goal)
                    .FirstOrDefaultAsync(m => m.Id == id);

                if (milestone == null)
                {
                    return new ResultModel<Milestone>
                    {
                        Errors = new List<string> { "Milestone not found" }
                    };
                }

                return new ResultModel<Milestone>
                {
                    Data = milestone
                };
            }
            catch (Exception ex)
            {
                return new ResultModel<Milestone>
                {
                    Errors = new List<string> { ex.Message }
                };
            }
        }

        public async Task<ResultModel<IEnumerable<Milestone>>> GetSubResourcesAsync(Guid milestoneId)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultModel<Milestone>> UpdateMilestoneAsync(Milestone milestone)
        {
            try
            {
                _context.Milestones.Update(milestone);
                await _context.SaveChangesAsync();

                return new ResultModel<Milestone>
                {
                    Data = milestone
                };
            }
            catch (Exception ex)
            {
                return new ResultModel<Milestone>
                {
                    Errors = new List<string> { ex.Message }
                };
            }
        }
    }
}
