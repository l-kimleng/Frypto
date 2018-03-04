using System;
using Frypto.Core.Models;
using Frypto.Core.Persistences;
using Frypto.Core.Persistences.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Frypto.Tests.Repositories
{
    [TestClass]
    public class ItineraryReservationRepositoryUnitTest
    {
        private FryptoDbContext Context { get; }
        
        public ItineraryReservationRepositoryUnitTest()
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
        [TestMethod]
        public void ItineraryReservation_Add_ReservationId_MustLargerThenZero()
        {
            var reservation = new ItineraryReservation
            {
                AgentId = 1,
                PassengerId = 1,
                TravelClassId = 1,
                ReservationDate = DateTime.Now,
                NumberInParty = 3
            };

            _itineraryReservationRepository.Add(reservation);
            Context.SaveChanges();

            Assert.IsTrue(reservation.Id > 0);
        }
    }
}
