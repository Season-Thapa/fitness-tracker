using System.ComponentModel.DataAnnotations;

namespace Pri.Ee.Api.Dtos.Goal
{
    public class GoalResponseDto
    {
        public Guid Id { get; set; }
        public int Target { get; set; }
    }
}
