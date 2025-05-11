using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuscatAirport.Models
{
    public class Officer
    {
        public int OfficerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Position { get; set; }
        public string? Department { get; set; }
        public string? ContactPhone { get; set; }
        public string? ContactEmail { get; set; }
        public int SecurityCheckpointId { get; set; } 
        public SecurityCheckpoint? SecurityCheckpoint { get; set; }
    }
}

