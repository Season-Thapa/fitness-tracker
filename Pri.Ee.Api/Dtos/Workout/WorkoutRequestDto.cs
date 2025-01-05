using System.ComponentModel.DataAnnotations;

namespace Pri.Ee.Api.Dtos.Workout
{
    public class WorkoutRequestDto
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public string Type { get; set; }
    }
}
