using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frypto.Core.Models;
using System.Data.Entity;

namespace Frypto.Core.Persistences.Repositories
{
    public class AirportRepository : IAirportRepository
    {
        private readonly FryptoDbContext _context;

        public AirportRepository(FryptoDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Airport>> Get(string code)
        {
            return await _context.Airports.Where(x => x.Code.StartsWith(code)).ToListAsync();
        }
    }
}
