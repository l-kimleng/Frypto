using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frypto.ViewModels
{
    public class PaymentViewModel
    {
        public int Id { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }

        public string Status { get; set; }
    }
}