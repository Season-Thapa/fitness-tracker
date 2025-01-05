using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Ee.Core.Dtos
{
    public class GoalDto
    {
        public string UserId { get; set; }
        public string Description { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Target must be greater than zero.")]
        public int Target { get; set; }
        public int Progress { get; set; }
    }
}
