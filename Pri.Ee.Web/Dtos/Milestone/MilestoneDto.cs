
using Microsoft.AspNetCore.Mvc.Rendering;
using Pri.Ee.Web.Dtos.Goal;

namespace Pri.Ee.Web.Dtos.Milestone
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
