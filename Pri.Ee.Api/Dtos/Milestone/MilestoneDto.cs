namespace Pri.Ee.Api.Dtos.Milestone
{
    public class MilestoneDto
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int Target { get; set; }
        public int Progress { get; set; }
        public Guid GoalId { get; set; }
    }
}
