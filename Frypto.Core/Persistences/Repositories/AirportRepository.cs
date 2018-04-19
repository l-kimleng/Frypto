using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frypto.Core.Models;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;

namespace Frypto.Core.Persistences.Repositories
{
    public class AirportRepository : IAirportRepository
    {
        private readonly FryptoDbContext _context;

        public AirportRepository(FryptoDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Airport>> Get(AirportQuery query)
        {
            var result = _context.Airports.Where(x => x.Code.StartsWith(query.Code));
            
            if (!string.IsNullOrEmpty(query.Name))
            {
                result = _context.Airports.Where(x => x.Location.Contains(query.Name));
            }

            return await result.ToListAsync();
        }
    }
}
