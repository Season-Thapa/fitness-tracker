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
    public class GoalService : IGoalService
    {
        public Task<ResultModel<Goal>> AddGoalAsync(Goal goal)
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<Goal>> DeleteGoalAsync(Goal goal)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DoesGoalIdExistAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<IEnumerable<Goal>>> GetAllGoalsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<Goal>> GetGoalByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<IEnumerable<Goal>>> GetGoalsByUserIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<Goal>> UpdateGoalAsync(Goal goal)
        {
            throw new NotImplementedException();
        }
    }
}
