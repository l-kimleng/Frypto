using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frypto.Core.Models;

namespace Frypto.Core.Persistences.Repositories
{
    public class ReservationPaymentRepository : IReservationPaymentRepository
    {
        private readonly FryptoDbContext _context;

        public ReservationPaymentRepository(FryptoDbContext context)
        {
            _context = context;
        }

        public async Task Add(ReservationPayment payment)
        {
            _context.ReservationPayments.Add(payment);

            await _context.SaveChangesAsync();
        }

        public async Task<ReservationPayment> Get(int id, bool isIncludeRelated = true)
        {
            var result = _context.ReservationPayments.Where(x => x.Id == id);

            if (isIncludeRelated)
            {
                result = result.Include(x => x.Payment)
                    .Include(x => x.Reservation);
            }

            return await result.FirstOrDefaultAsync();
        }
    }
}
