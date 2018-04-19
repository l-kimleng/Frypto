using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Frypto.BindingModels;
using Frypto.Core.Models;
using Frypto.Core.Persistences;
using Frypto.Core.Persistences.Repositories;

namespace Frypto.Controllers
{
    [RoutePrefix("api/Airports")]
    public class AirportsController : ApiController
    {
        private FryptoDbContext Context { get; }

        public AirportsController()
        {
            Context = FryptoDbContext.Create();
        }

        protected override void Dispose(bool disposing)
        {
            Context.Dispose();
            base.Dispose(disposing);
        }

        private IAirportRepository _airportRepository;

        public IAirportRepository AirportRepository
        {
            get
            {
                if (_airportRepository == null)
                {
                    return _airportRepository = new AirportRepository(Context);
                }
                return _airportRepository;
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IHttpActionResult> GetAirport([FromUri]AirportBindingModel model)
        {
            if (string.IsNullOrEmpty(model.Code) || model.Code.ToCharArray().Length > 3) return BadRequest(model.Code);

            var query = new AirportQuery()
            {
                Code = model.Code,
                Name = model.Name,
                Location = model.Location
            };

            var airports = await AirportRepository.Get(query);

            if (!airports.Any()) return NotFound();

            return Ok(airports);
        }
    }
}
