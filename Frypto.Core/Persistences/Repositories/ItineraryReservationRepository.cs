using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Frypto.Core.Models;

namespace Frypto.Core.Persistences.Repositories
{
    public class ItineraryReservationRepository : IItineraryReservationRepository
    {
        private readonly FryptoDbContext _context;

        public ItineraryReservationRepository(FryptoDbContext context)
        {
            _context = context;
        }

        public async Task Add(ItineraryReservation reservation)
        {
            _context.ItineraryReservations.Add(reservation);

            await _context.SaveChangesAsync();
        }

        public async Task<ItineraryReservation> Get(int id, bool isInclude = true)
        {
            var result =  _context.ItineraryReservations.Where(x => x.Id == id);

            if (isInclude)
            {
                result = result.Include(x => x.Agent)
                    .Include(x => x.Passenger)
                    .Include(x => x.TravelClass)
                    .Include(x => x.TicketType)
                    .Include(x => x.ReservationStatus);
            }

            return await result.FirstOrDefaultAsync();
        }

        public async Task<IList<ItineraryReservation>> GetByQuery(ReservationQuery query, bool isInclude = true)
        {
            var result = _context.ItineraryReservations.AsQueryable();

            if (query != null)
            {
                // Apply filtering
                
                
                // Apply ordering
                result = query.IsSortAscending ? result.OrderBy(x => x.ReservationDate) : result.OrderByDescending(x => x.ReservationDate);

                // Apply paging
                var page = query.Page;
                var size = query.PageSize;
                if (page <= 0)
                    page = 1;
                if (size <= 0)
                    size = 5;

                result = result.Skip((page-1) * size).Take(size);

            }

            if (isInclude)
            {
                result = result.Include(x => x.Agent)
                    .Include(x => x.Passenger)
                    .Include(x => x.TravelClass)
                    .Include(x => x.TicketType)
                    .Include(x => x.ReservationStatus);
            }

            return await result.ToListAsync();
        }
    }
}
