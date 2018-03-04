using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frypto.Core.Models
{
    public class ReservationPayment
    {
        public int Id { get; set; }

        public int ReservationId { get; set; }
        public ItineraryReservation Reservation { get; set; }

        public int PaymentId { get; set; }
        public Payment Payment { get; set; }
    }
}
