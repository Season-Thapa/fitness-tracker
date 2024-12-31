using Pri.Ee.Core.Entities;
using Pri.Ee.Core.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Ee.Core.Services.Interfaces
{
    public interface IGoalService
    {
        Task<ResultModel<Goal>> GetGoalByIdAsync(Guid id);
        Task<ResultModel<IEnumerable<Goal>>> GetAllGoalsAsync();
        Task<ResultModel<IEnumerable<Goal>>> GetGoalsByUserIdAsync(Guid userId);
        Task<ResultModel<Goal>> AddGoalAsync(Goal goal);
        Task<ResultModel<Goal>> UpdateGoalAsync(Goal goal);
        Task<ResultModel<Goal>> DeleteGoalAsync(Goal goal);
        Task<bool> DoesGoalIdExistAsync(Guid id);
        Task<int> CalculateProgressAsync(Guid id);
    }
}
