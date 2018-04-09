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

        [HttpGet]
        public async Task<IHttpActionResult> GetReservation([FromUri]ReservationQuery query)
        {
            var result = await ItineraryReservationRepository.GetByQuery(query);
            var list = new List<ReservationViewModel>();

            foreach (var reservation in result)
            {
                list.Add(BuildViewModel(reservation));
              
            }

            return Ok(list);
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
                TicketTypeId = model.TicketTypeId,
                ReservationStatusId = model.ReservationStatusId ?? 1,
                NumberInParty = model.NumberInParty,
                ReservationDate = model.ReservationDate
            };

            await ItineraryReservationRepository.Add(reservation);

            var result = await ItineraryReservationRepository.Get(reservation.Id);

            return Ok(BuildViewModel(result));
        }

        private static ReservationViewModel BuildViewModel(ItineraryReservation model)
        {
            return new ReservationViewModel
            {
                Id = model.Id,
                Agent = new AgentViewModel
                {
                    Id = model.AgentId,
                    Name = model.Agent.Name,
                    Description = model.Agent.Description
                },
                Passenger = new PassengerViewModel
                {
                    Id = model.PassengerId,
                    FirstName = model.Passenger.FirstName,
                    LastName = model.Passenger.LastName,
                    PhoneNumber = model.Passenger.PhoneNumber,
                    Address = model.Passenger.Address,
                    City = model.Passenger.City,
                    Email = model.Passenger.Email,
                    Country = model.Passenger.Country
                },
                TravelClass = new TravelClassViewModel
                {
                    Id = model.TravelClassId,
                    Class = model.TravelClass.Class
                },
                TicketType = new TicketTypeViewModel
                {
                    Id = model.TicketTypeId,
                    Name = model.TicketType.Name
                },
                ReservationStatus = new ReservationStatusViewModel
                {
                    Id = model.ReservationStatusId,
                    Label = model.ReservationStatus.Label
                },
                NumberInParty = model.NumberInParty,
                ReservationDate = model.ReservationDate
            };
        }
    }
}