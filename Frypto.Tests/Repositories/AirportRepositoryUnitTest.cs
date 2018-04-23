using Frypto.Core.Persistences;
using Frypto.Core.Persistences.Repositories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frypto.Core.Models;

namespace Frypto.Tests.Repositories
{
    [TestFixture]
    public class AirportRepositoryUnitTest
    {
        private FryptoDbContext Context { get; set; }

        [SetUp]
        public void Setup()
        {
            Context = FryptoDbContext.Create();
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

        [Test]
        public async Task AirportRepository_GetByCode_MustExisted()
        {
            // Arrange
            var airportQuery = new AirportQuery
            {
                Code = "PNH",
                Name = "Phnom Penh",
                Location = "Cambodia"
            };

            // Act
            var result = await AirportRepository.Get(airportQuery);

            // Assert

            Assert.That(result.Any());
        }
    }
}
