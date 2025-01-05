using System.ComponentModel.DataAnnotations;

namespace Pri.Ee.Api.Dtos.Goal
{
    public class GoalRequestDto
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public int Target { get; set; }
        public int Progress { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
    }
}
