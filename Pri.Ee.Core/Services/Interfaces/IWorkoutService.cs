using Pri.Ee.Core.Dtos;
using Pri.Ee.Core.Entities;
using Pri.Ee.Core.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Ee.Core.Services.Interfaces
{
    public interface IWorkoutService
    {
        Task<ResultModel<Workout>> GetWorkoutByIdAsync(Guid id);
        Task<ResultModel<IEnumerable<Workout>>> GetAllWorkoutsAsync();
        Task<ResultModel<IEnumerable<Workout>>> GetWorkoutsByUserIdAsync(Guid userId);
        Task<ResultModel<Workout>> AddWorkoutAsync(Workout workout);
        Task<ResultModel<Workout>> UpdateWorkoutAsync(Workout workout);
        Task<ResultModel<Workout>> DeleteWorkoutAsync(Workout workout);
        Task<bool> DoesWorkoutIdExistAsync(Guid id);


    }
}
