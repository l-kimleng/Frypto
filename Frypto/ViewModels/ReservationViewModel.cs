using System;

namespace Frypto.ViewModels
{
    public class ReservationViewModel
    {
        public int Id { get; set; }
        public AgentViewModel Agent { get; set; }
        public PassengerViewModel Passenger { get; set; }
        public TravelClassViewModel TravelClass { get; set; }
        public DateTime ReservationDate { get; set; }
        public byte NumberInParty { get; set; }
        public TicketTypeViewModel TicketTypeViewModel { get; set; }
    }
}