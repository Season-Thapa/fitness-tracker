using System.ComponentModel.DataAnnotations;

namespace Pri.Ee.Web.Dtos.Goal
{
    public class GoalRequestDto
    {
        public Guid Id { get; set; }
        public int Target { get; set; }
        public int Progress { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
    }
}
