using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuscatAirport.Models
{
    public class Airline
    {
        public int AirlineId { get; set; }
        public string? Name { get; set; }
        public string? ContactNumber { get; set; }
        public string? ContactEmail { get; set; }
        public string? RepresentativeName { get; set; }

        public ICollection<Flight> Flights { get; set; }
        public ICollection<Gate> Gates { get; set; }
    }
}
