using System.Data.Entity;
using Frypto.Core.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Frypto.Core.Persistences
{
    public class FryptoDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<TravelClass> TravelClasses { get; set; }
        public DbSet<ItineraryReservation> ItineraryReservations { get; set; }
        public DbSet<PaymentStatus> PaymentStatuses { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<ReservationPayment> ReservationPayments { get; set; }

        public FryptoDbContext()
            : base("DefaultConnection", false)
        {
        }
        
        public static FryptoDbContext Create()
        {
            return new FryptoDbContext();
        }
    }
}