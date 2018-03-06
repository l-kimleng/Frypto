using System.Threading.Tasks;
using System.Web.Http;
using Frypto.BindingModels;
using Frypto.Core.Models;
using Frypto.Core.Persistences;
using Frypto.Core.Persistences.Repositories;
using Frypto.ViewModels;

namespace Frypto.Controllers
{
    [Authorize]
    [RoutePrefix("api/Payments")]
    public class PaymentsController : ApiController
    {
        private FryptoDbContext Context { get; }

        public PaymentsController()
        {
            Context = FryptoDbContext.Create();
        }

        private IReservationPaymentRepository _reservationPaymentRepository;

        public IReservationPaymentRepository ReservationPaymentRepository
        {
            get
            {
                if (_reservationPaymentRepository == null)
                {
                    return _reservationPaymentRepository = new ReservationPaymentRepository(Context);
                }
                return _reservationPaymentRepository;
            }
        }

        protected override void Dispose(bool disposing)
        {
            Context.Dispose();
            base.Dispose(disposing);
        }

        [HttpPost]
        public async Task<IHttpActionResult> CreatePayment(ReservationPaymentBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var reservationPayment = new ReservationPayment
            {
                ReservationId = model.ReservationId,
                Payment = new Payment
                {
                    PaymentDate = model.Payment.PaymentDate,
                    Amount = model.Payment.Amount,
                    PaymentStatusId = (model.Payment.StatusId == 0) ? 2 : model.Payment.StatusId
                }
            };

            await ReservationPaymentRepository.Add(reservationPayment);

            var result = await ReservationPaymentRepository.Get(reservationPayment.Id);

            var reservationViewModel = new ReservationPaymentViewModel
            {
                Id = reservationPayment.Id,
                Payment = new PaymentViewModel
                {
                    Id = result.PaymentId,
                    PaymentDate = result.Payment.PaymentDate,
                    Amount = result.Payment.Amount,
                    //Status = result.Payment.Status.Description
                },
                Reservation = new ReservationViewModel
                {
                    Id = result.ReservationId,
                    ReservationDate = result.Reservation.ReservationDate,
                    NumberInParty = result.Reservation.NumberInParty
                }
            }; 

            return Ok(reservationViewModel);
        }
    }
}
