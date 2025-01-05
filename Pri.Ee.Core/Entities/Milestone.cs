using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Ee.Core.Entities
{
    public class Milestone
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int Target { get; set; } 
        public int Progress { get; set; } 
        public Guid GoalId { get; set; }
        public Goal Goal { get; set; }
    }
}
