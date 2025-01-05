namespace Pri.Ee.Web.Dtos.Goal
{
    public class GoalDto
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public int Target { get; set; }
        public int Progress { get; set; }
        public string? Description { get; set; }
    }
}
