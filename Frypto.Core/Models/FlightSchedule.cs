using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frypto.Core.Models
{
    public class FlightSchedule
    {
        public int Id { get; set; }
        public string FlightNumber { get; set; }
        public string AircraftType { get; set; }

        public int OriginAirportId { get; set; }
        public Airport OriginAirport { get; set; }

        public int DestinationAirportId { get; set; }
        public Airport DestinationAirport { get; set; }

        public DateTime DepartureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }
    }
}
