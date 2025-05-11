using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuscatAirport.Models
{
    public class Terminal
    {
        public int TerminalId { get; set; }
        public string? TerminalName { get; set; }
        public int Capacity { get; set; }
        public string ?Location { get; set; }

        public ICollection<Gate> Gates { get; set; }
        public ICollection<SecurityCheckpoint> SecurityCheckpoints { get; set; }
    }
}
