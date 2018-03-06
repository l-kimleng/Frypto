using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frypto.ViewModels
{
    public class ReservationPaymentViewModel
    {
        public int Id { get; set; }
        public ReservationViewModel Reservation { get; set; }
        public PaymentViewModel Payment { get; set; }
    }
}