using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frypto.BindingModels
{
    public class ReservationPaymentBindingModel
    {
        public int ReservationId { get; set; }
        public PaymentBindingModel Payment { get; set; }
    }
}