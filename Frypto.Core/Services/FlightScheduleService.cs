using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frypto.Core.Models;
using Frypto.Core.Persistences;
using Frypto.Core.Persistences.Repositories;

namespace Frypto.Core.Services
{
    public class FlightScheduleService : IFlightScheduleService
    {
        private readonly ILegRepository _legRepository;
        private readonly IFlightScheduleRepository _flightScheduleRepository;
        private readonly IFlightCostRepository _flightCostRepository;

        public FlightScheduleService(ILegRepository legRepository, IFlightScheduleRepository flightScheduleRepository,
            IFlightCostRepository flightCostRepository)
        {
            _legRepository = legRepository;
            _flightScheduleRepository = flightScheduleRepository;
            _flightCostRepository = flightCostRepository;
        }

        public async Task<IList<FlightDetailedSchedule>> GetBy(int originAirportId, int destinationAirportId, DateTime departureDate)
        {
            var leg = await _legRepository.GetBy(originAirportId, destinationAirportId);
            var result = new List<FlightDetailedSchedule>();
            if (leg.Any())
            {
                foreach (var l in leg)
                {
                    var detail = new FlightDetailedSchedule { Leg = l };
                    var schedule = await _flightScheduleRepository.GetBy(originAirportId, l.FlightNumber, departureDate);
                    if (schedule.Any())
                    {
                        var dicFlight = new Dictionary<FlightSchedule, FlightCost>();
                        foreach (var s in schedule)
                        {
                            var cost = await _flightCostRepository.GetBy(s.FlightNumber);
                            if (cost != null)
                            {
                                dicFlight.Add(s, cost);
                            }
                        }
                        detail.FlightSchedules.Add(dicFlight);
                    }
                    result.Add(detail);
                }
            }

            return result;
        }
    }
}
