namespace Pri.Ee.Web.Dtos.Workout
{
    public class WorkoutRequestDto
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public int Duration { get; set; }
        public int CaloriesBurned { get; set; }
        public DateTime Date { get; set; }
    }
}
