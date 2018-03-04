using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Frypto.BindingModels;
using Frypto.Core.Models;
using Frypto.Core.Persistences;
using Frypto.Core.Persistences.Repositories;
using Frypto.ViewModels;

namespace Frypto.Controllers
{
    [Authorize]
    [RoutePrefix("api/Reservations")]
    public class ReservationsController : ApiController
    {
        private FryptoDbContext Context { get; }
        
        public ReservationsController()
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

        protected override void Dispose(bool disposing)
        {
            Context.Dispose();
            base.Dispose(disposing);
        }

        [HttpPost]
        public async Task<IHttpActionResult> CreateReservation(ReservationBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var reservation = new ItineraryReservation
            {
                AgentId = model.AgentId,
                PassengerId = model.PassengerId,
                TravelClassId = model.TravelClassId,
                NumberInParty = model.NumberInParty,
                ReservationDate = model.ReservationDate
            };

            await ItineraryReservationRepository.Add(reservation);

            var result = await ItineraryReservationRepository.Get(reservation.Id);
            
            var reservationViewModel = new ReservationViewModel
            {
                Id = result.Id,
                Agent = new AgentViewModel
                {
                    Id = result.AgentId,
                    Name = result.Agent.Name,
                    Description = result.Agent.Description
                },
                Passenger = new PassengerViewModel
                {
                    Id = result.PassengerId,
                    FirstName = result.Passenger.FirstName,
                    LastName = result.Passenger.LastName,
                    PhoneNumber = result.Passenger.PhoneNumber,
                    Address = result.Passenger.Address,
                    City = result.Passenger.City,
                    Email = result.Passenger.Email,
                    Country = result.Passenger.Country
                },
                TravelClass = new TravelClassViewModel
                {
                    Id = result.TravelClassId,
                    Class = result.TravelClass.Class
                },
                NumberInParty = result.NumberInParty,
                ReservationDate = result.ReservationDate
            };

            return Ok(reservationViewModel);
        }
    }
}
