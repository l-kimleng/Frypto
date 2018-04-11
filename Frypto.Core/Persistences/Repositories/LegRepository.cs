using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frypto.Core.Models;

namespace Frypto.Core.Persistences.Repositories
{
    public class LegRepository : ILegRepository
    {
        private readonly FryptoDbContext _context;

        public LegRepository(FryptoDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Leg>> GetBy(int originAirportId, int destinationAirportId)
        {
            return await _context.Legs
                .Include(x => x.OriginAirport)
                .Include(x => x.DestinationAirport)
                .Where(x => x.OriginAirportId == originAirportId
                         && x.DestinationAirportId == destinationAirportId).ToListAsync();
        }
    }
}
