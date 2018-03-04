using System;

namespace Frypto.Core.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }

        public int PaymentStatusId { get; set; }
        public PaymentStatus Status { get; set; }
    }
}
