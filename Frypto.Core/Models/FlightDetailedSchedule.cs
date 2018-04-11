using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frypto.Core.Models
{
    public class FlightDetailedSchedule
    {
        public Leg Leg { get; set; }
        public IList<Dictionary<FlightSchedule, FlightCost>> FlightSchedules { get; set; }

        public FlightDetailedSchedule()
        {
            FlightSchedules = new List<Dictionary<FlightSchedule, FlightCost>>();
        }
    }
}
