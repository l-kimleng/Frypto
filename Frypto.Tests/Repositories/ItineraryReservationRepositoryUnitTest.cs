using System;
using System.Threading.Tasks;
using Frypto.Core.Models;
using Frypto.Core.Persistences;
using Frypto.Core.Persistences.Repositories;
using NUnit.Framework;

namespace Frypto.Tests.Repositories
{
    [TestFixture]
    public class ItineraryReservationRepositoryUnitTest
    {
        private FryptoDbContext Context { get; set; }
        
        [SetUp]
        public void Setup()
        {
            Context = FryptoDbContext.Create();
        }

        private IItineraryReservationRepository _itineraryReservationRepository;

        public IItineraryReservationRepository ItineraryReservationRepository
        {
            get
            {
                if (_itineraryReservationRepository == null)
                {
                    return _itineraryReservationRepository = new ItineraryReservationRepository(Context);
                }
                return _itineraryReservationRepository;
            }
        }
        [Test]
        public async Task ItineraryReservation_Add_ReservationId_MustLargerThenZero()
        {
            var reservation = new ItineraryReservation
            {
                AgentId = 1,
                PassengerId = 1,
                TravelClassId = 1,
                ReservationDate = DateTime.Now,
                NumberInParty = 3
            };

            await ItineraryReservationRepository.Add(reservation);
            //Context.SaveChanges();

            Assert.That(reservation.Id > 0);
        }

        [Test]
        public async Task ItineraryReservation_Get_ReservationById_MustLargerThenZero()
        {
            var reservation = await ItineraryReservationRepository.Get(1, false);

            Assert.That(reservation.Id > 0);
        }
    }
}
