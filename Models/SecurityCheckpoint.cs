using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuscatAirport.Models
{
    public class SecurityCheckpoint
    {
        [Key]

        public int CheckpointId { get; set; }
        public int TerminalId { get; set; }
        public Terminal Terminal { get; set; }

        public string TerminalName { get; set; } 
        public int PassengerCapacity { get; set; }
        public string Location { get; set; }
        public ICollection<Officer> Officers { get; set; } 

    }
}
