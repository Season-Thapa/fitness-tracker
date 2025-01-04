using System.ComponentModel.DataAnnotations;

namespace Pri.Ee.Api.Dtos.Goal
{
    public class GoalResponseDto
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public int Target { get; set; }
        public int Progress { get; set; }
    }
}
