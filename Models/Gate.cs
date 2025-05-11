using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuscatAirport.Models
{
    public class Gate
    {
        public int GateId { get; set; }
        public int TerminalId { get; set; }
        public Terminal Terminal { get; set; }

        public int AirlineId { get; set; }
        public Airline Airline { get; set; }

        public string GateNumber { get; set; }
        public bool AvailabilityStatus { get; set; }

        public ICollection<Flight> Flights { get; set; }
    }
}
