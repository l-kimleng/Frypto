using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frypto.Core.Models;

namespace Frypto.Core.Persistences
{
    public interface IFlightScheduleManager
    {
        Task<IList<FlightDetailedSchedule>> GetBy(int originAirportId, int destinationAirportId, DateTime departureDate);
    }
}
