using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuscatAirport.Models
{
    public class Baggage
    {
        public int BaggageId { get; set; }
        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; }

        public double Weight { get; set; }
        public string TrackingNumber { get; set; }
    }
}
