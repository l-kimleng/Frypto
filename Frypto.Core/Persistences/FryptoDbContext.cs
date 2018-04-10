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
        public DbSet<TicketType> TicketTypes { get; set; }
        public DbSet<ReservationStatus> ReservationStatus { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Leg> Legs { get; set; }
        public DbSet<FlightSchedule> FlightSchedules { get; set; }
        public DbSet<FlightCost> FlightCosts { get; set; }

        public FryptoDbContext()
            : base("DefaultConnection", false)
        {
        }
        
        public static FryptoDbContext Create()
        {
            return new FryptoDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Leg>()
                .HasRequired(x => x.OriginAirport)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Leg>()
                .HasRequired(x => x.DestinationAirport)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FlightSchedule>()
                .HasRequired(x => x.OriginAirport)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FlightSchedule>()
                .HasRequired(x => x.DestinationAirport)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FlightCost>()
                .HasKey(x => new {x.FlightNumber, x.ValidFrom});

        }
    }
}