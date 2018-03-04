using System.Threading.Tasks;
using Frypto.Core.Models;

namespace Frypto.Core.Persistences.Repositories
{
    public interface IItineraryReservationRepository
    {
        Task Add(ItineraryReservation reservation);
        Task<ItineraryReservation> Get(int id, bool isInclude = true);
    }
}