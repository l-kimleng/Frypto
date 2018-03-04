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
                    .Include(x => x.TravelClass);
            }

            return await result.FirstOrDefaultAsync();
        }
    }
}
