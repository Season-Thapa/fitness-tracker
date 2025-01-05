using System.ComponentModel.DataAnnotations;

namespace Pri.Ee.Api.Dtos.Workout
{
    public class WorkoutRequestDto
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "name is required")]
        public string Type { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Duration must be greater than zero.")]
        public int Duration { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Calories burned must be zero or greater.")]
        public int CaloriesBurned { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
