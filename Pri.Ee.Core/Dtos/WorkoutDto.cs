using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Ee.Core.Dtos
{
    public class WorkoutDto
    {
        public Guid UserId { get; set; }

        [Required]
        public string Type { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Duration must be greater than zero.")]
        public int Duration { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Calories burned must be zero or greater.")]
        public int CaloriesBurned { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
