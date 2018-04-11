using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frypto.Core.Models;

namespace Frypto.Core.Persistences.Repositories
{
    public class FlightCostRepository : IFlightCostRepository
    {
        private readonly FryptoDbContext _context;

        public FlightCostRepository(FryptoDbContext context)
        {
            _context = context;
        }

        public async Task<FlightCost> GetBy(string flightNumber)
        {
            return await _context.FlightCosts
                    .FirstOrDefaultAsync(x => x.FlightNumber == flightNumber);
        }
    }
}
