using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frypto.BindingModels
{
    public class PaymentBindingModel
    {
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public int StatusId { get; set; }
    }
}