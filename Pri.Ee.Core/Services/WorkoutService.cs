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
    public class WorkoutService : IWorkoutService
    {
        private readonly ApplicationDbContext _context;

        public WorkoutService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ResultModel<Workout>> DeleteWorkoutAsync(Workout workout)
        {
           _context.Workouts.Remove(workout);
            await _context.SaveChangesAsync();
            return new ResultModel<Workout>
            {
                Data = workout
            };

        }

        public async Task<ResultModel<IEnumerable<Workout>>> GetAllWorkoutsAsync()
        {
            var result = await _context.Workouts.ToListAsync();
            var resultModel = new ResultModel<IEnumerable<Workout>>()
            {
                Data = result,
            };
            return resultModel;
        }

        public async Task<ResultModel<Workout>> GetWorkoutByIdAsync(Guid id)
        {
            var selectedWorkout = await _context.Workouts.FirstOrDefaultAsync(w => w.Id ==id);
            if (selectedWorkout == null)
            {
                new ResultModel<Workout>
                {
                    Errors = new List<string>
                      { $"There is no workout" }
                };
            }
            return new ResultModel<Workout>
            {
                Data = selectedWorkout
            };
        }

        public async Task<ResultModel<IEnumerable<Workout>>> GetWorkoutsByUserIdAsync(Guid userId)
        {
            var workout = await _context.Workouts
                .Include(x => x.UserId)
                .Where(w => w.UserId.Equals(userId)).ToListAsync();
            return new ResultModel<IEnumerable<Workout>> { Data = workout };

        }

        public async Task<ResultModel<Workout>> UpdateWorkoutAsync(Workout workout)
        {
            var selectedWorkout = await _context.Workouts.FirstOrDefaultAsync(w =>  w.Id == workout.Id);
            if (selectedWorkout == null)
            {
                new ResultModel<Workout>
                {
                    Errors = new List<string>
                      { $"There is no workout with name = {workout.Type}" }
                };
            }
            _context.Workouts.Update(workout);
            await _context.SaveChangesAsync();
            return new ResultModel<Workout>
            {
                Data = workout
            };
        }

        public async Task<ResultModel<Workout>> AddWorkoutAsync(Workout workout)
        {        
            
            _context.Workouts.Add(workout);
            await _context.SaveChangesAsync();
            return new ResultModel<Workout> { Data = workout };

        }
   
    }
}
