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
            var result = new List<Airport>();

            if (string.IsNullOrEmpty(query.Code) && string.IsNullOrEmpty(query.Name)
                && string.IsNullOrEmpty(query.Location))
                    return await _context.Airports.ToListAsync();

            if (!string.IsNullOrEmpty(query.Code))
            {
                var listByCode = await _context.Airports.Where(x => x.Code.StartsWith(query.Code)).ToListAsync();
                result.AddRange(listByCode);
            }    
                
            if (!string.IsNullOrEmpty(query.Name))
            {
                var listByName = await _context.Airports.Where(x => x.Name.Contains(query.Name)).ToListAsync();

                if (result.Count == 0) result.AddRange(listByName);
                else
                {
                    foreach (var airport in listByName)
                    {
                        if (result.Any(x => x.Id != airport.Id))
                        {
                            result.Add(airport);
                        }
                    }
                }
                
            }

            if (!string.IsNullOrEmpty(query.Location))
            {
                var listByLocation = await _context.Airports.Where(x => x.Location.Contains(query.Location))
                    .ToListAsync();
                if (result.Count == 0) result.AddRange(listByLocation);
                else
                {
                    foreach (var airport in listByLocation)
                    {
                        if (result.Any(x => x.Id != airport.Id))
                        {
                            result.Add(airport);
                        }
                    }
                }
            }

            return result;
        }
    }
}
