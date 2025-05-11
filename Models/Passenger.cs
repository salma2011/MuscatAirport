using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuscatAirport.Models
{
    public class Passenger
    {
        public int PassengerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? Nationality { get; set; }
        public string? PassportNumber { get; set; }
        public string? ContactPhone { get; set; }
        public string? ContactEmail { get; set; }

        public ICollection<Baggage> Baggage { get; set; }
    }
}
