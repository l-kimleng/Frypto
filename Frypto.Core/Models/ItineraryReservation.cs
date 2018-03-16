using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frypto.Core.Models
{
    public class ItineraryReservation
    {
        public int Id { get; set; }

        public int AgentId { get; set; }
        public Agent Agent { get; set; }

        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; }

        public int TravelClassId { get; set; }
        public TravelClass TravelClass { get; set; }

        public DateTime ReservationDate { get; set; }
        public byte NumberInParty { get; set; }

        public int? TicketTypeId { get; set; }
        public TicketType TicketType { get; set; }

    }
}
