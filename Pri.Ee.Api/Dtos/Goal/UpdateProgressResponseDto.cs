namespace Pri.Ee.Api.Dtos.Goal
{
    public class UpdateProgressResponseDto
    {
        public Guid GoalId { get; set; }
        public int UpdatedProgress { get; set; }
        public int Target { get; set; }
        public bool IsGoalAchieved { get; set; }
        public string Message { get; set; }
    }
}
