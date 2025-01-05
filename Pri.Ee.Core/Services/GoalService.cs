using Microsoft.EntityFrameworkCore;
using Pri.Ee.Core.Data;
using Pri.Ee.Core.Entities;
using Pri.Ee.Core.Services.Interfaces;
using Pri.Ee.Core.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Ee.Core.Services
{
    public class GoalService : IGoalService
    {
        private readonly ApplicationDbContext _context;

        public GoalService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ResultModel<Goal>> AddGoalAsync(Goal goal)
        {
            _context.Goals.Add(goal);
            await _context.SaveChangesAsync();
            return new ResultModel<Goal>
            {
                Data = goal
            };
        }

        public async Task<int> CalculateProgressAsync(Guid id)
        {
            var goal = await _context.Goals.FindAsync(id);
            if (goal == null)
            {
                throw new KeyNotFoundException("Goal not found");
            }
            var totalProgress = await _context.Workouts
            .Where(w => w.UserId == goal.UserId &&
                        w.Date >= goal.StartDate &&
                        w.Date <= goal.EndDate)
            .SumAsync(w => w.CaloriesBurned);

            return totalProgress;
        }


        public async Task<ResultModel<Goal>> DeleteGoalAsync(Goal goal)
        {
            _context.Goals.Remove(goal);
            await _context.SaveChangesAsync();
            return new ResultModel<Goal>
            {
                Data = goal
            };

        }

        public async Task<bool> DoesGoalIdExistAsync(Guid id)
        {
            return await _context.Goals.AnyAsync(g => g.Id == id);
        }

        public async Task<ResultModel<IEnumerable<Goal>>> GetAllGoalsAsync()
        {
            var result = await _context.Goals.ToListAsync();
            var resultModel = new ResultModel<IEnumerable<Goal>>()
            {
                Data = result,
            };
            return resultModel;
        }

        public async Task<ResultModel<Goal>> GetGoalByIdAsync(Guid id)
        {
            var selectedGoal = await _context.Goals.FirstOrDefaultAsync(g => g.Id == id);
            if (selectedGoal == null)
            {
                new ResultModel<Goal>
                {
                    Errors = new List<string>
                    {
                        "There is no goal"
                    }
                };
            }
            return new ResultModel<Goal>
            {
                Data = selectedGoal
            };
        }

        public async Task<ResultModel<IEnumerable<Goal>>> GetGoalsByUserIdAsync(string userId)
        {
            var goal = await _context.Goals
            .Where(w => w.UserId.Equals(userId)).ToListAsync();
            if (goal != null)
            {
                return new ResultModel<IEnumerable<Goal>> { Data = goal };
            }
            return new ResultModel<IEnumerable<Goal>>
            {
                Errors = new List<string>
                {
                        "There is no goal"
                }
            };

           
        }

        public async Task<ResultModel<Goal>> UpdateGoalAsync(Goal goal)
        {
            if (!await DoesGoalIdExistAsync(goal.Id))
            {
                return new ResultModel<Goal>
                {
                    Errors = new List<string>
                    {
                        "There are no goal to update"
                    }
                };
            }
            _context.Goals.Update(goal);
            await _context.SaveChangesAsync();
            return new ResultModel<Goal>
            {
                Data = goal
            };
        }

        public async Task<ResultModel<Goal>> UpdateGoalProgressAsync(Guid id)
        {
            var goal = await _context.Goals.FindAsync(id);
            if (goal == null) throw new KeyNotFoundException("Goal not found");

            var progress = await CalculateProgressAsync(id);
            goal.Progress = progress;

            _context.Goals.Update(goal);
            await _context.SaveChangesAsync();
            return new ResultModel<Goal>
            {
                Data = goal
            };
        }
    
    }
}
