using System;
using System.ComponentModel.DataAnnotations;

namespace Frypto.BindingModels
{
    public class ReservationBindingModel
    {
        [Required]
        public int AgentId { get; set; }
        [Required]
        public int PassengerId { get; set; }
        [Required]
        public int TravelClassId { get; set; }
        [Required]
        public DateTime ReservationDate { get; set; }
        [Required]
        public byte NumberInParty { get; set; }
        [Required]
        public int TicketTypeId { get; set; }
        public int? ReservationStatusId { get; set; }
    }
}