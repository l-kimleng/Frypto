using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Frypto.Core.Models;

namespace Frypto.Core.Services
{
    public interface IFlightScheduleService
    {
        Task<IList<FlightDetailedSchedule>> GetBy(int originAirportId, int destinationAirportId, DateTime departureDate);
    }
}
