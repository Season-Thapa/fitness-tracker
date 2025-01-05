using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Ee.Core.Entities
{
    public class Workout
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public string Type { get; set; }
        public int Duration { get; set; }
        public int CaloriesBurned { get; set; }
        public DateTime Date { get; set; }
    }
}
