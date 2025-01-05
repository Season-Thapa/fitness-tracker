using System.ComponentModel.DataAnnotations;

namespace Pri.Ee.Web.Dtos.Workout
{
    public class WorkoutRequestDto
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public int Duration { get; set; }
        public int CaloriesBurned { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
