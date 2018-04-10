using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frypto.Core.Models
{
    public class FlightCost
    {
        public string FlightNumber { get; set; }
        public string AircraftType { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public decimal Cost { get; set; }
    }
}
