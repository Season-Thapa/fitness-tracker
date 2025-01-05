using Pri.Ee.Core.Entities;
using Pri.Ee.Core.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Ee.Core.Services.Interfaces
{
    public interface IMilestoneService
    {
        Task<ResultModel<Milestone>> AddMilestoneAsync(Milestone milestone);
        Task<ResultModel<Milestone>> GetMilestoneByIdAsync(Guid id);
        Task<ResultModel<IEnumerable<Milestone>>> GetAllMilestonesAsync();
        Task<ResultModel<Milestone>> UpdateMilestoneAsync(Milestone milestone);
        Task<ResultModel<Milestone>> DeleteMilestoneAsync(Guid milestoneId);
        Task<ResultModel<IEnumerable<Milestone>>> GetSubResourcesAsync(Guid milestoneId);
    }
}
