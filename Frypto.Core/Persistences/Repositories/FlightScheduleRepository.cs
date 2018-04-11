using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frypto.Core.Models;

namespace Frypto.Core.Persistences.Repositories
{
    public class FlightScheduleRepository : IFlightScheduleRepository
    {
        private readonly FryptoDbContext _context;

        public FlightScheduleRepository(FryptoDbContext context)
        {
            _context = context;
        }

        public async Task<IList<FlightSchedule>> GetBy(int originAirportId, string flightNumber, DateTime actualDepartureDate)
        {
            return await _context.FlightSchedules
                .Include(x => x.OriginAirport)
                .Include(x => x.DestinationAirport)
                .Where(x => x.OriginAirportId == originAirportId
                        && x.FlightNumber == flightNumber
                        && DbFunctions.TruncateTime(x.DepartureDateTime) == actualDepartureDate.Date).ToListAsync();
        }
    }
}
