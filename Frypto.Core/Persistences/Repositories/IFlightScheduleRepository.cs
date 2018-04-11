using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frypto.Core.Models;

namespace Frypto.Core.Persistences.Repositories
{
    public interface IFlightScheduleRepository
    {
        Task<IList<FlightSchedule>> GetBy(int originAirportId, string flightNumber, DateTime actualDepartureDate);
    }
}
