﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frypto.Core.Persistences;
using Frypto.Core.Persistences.Repositories;
using NUnit.Framework;

namespace Frypto.Tests.Repositories
{
    [TestFixture]
    public class FlightScheduleManagerUnitTest
    {
        private FryptoDbContext Context { get; set; }

        [SetUp]
        public void Setup()
        {
            Context = FryptoDbContext.Create();
        }

        private IFlightScheduleRepository _flightScheduleRepository;

        public IFlightScheduleRepository FlightScheduleRepository
        {
            get
            {
                if (_flightScheduleRepository == null)
                {
                    return _flightScheduleRepository = new FlightScheduleRepository(Context);
                }
                return _flightScheduleRepository;
            }
        }

        private IFlightCostRepository _flightCostRepository;

        public IFlightCostRepository FlightCostRepository
        {
            get
            {
                if (_flightCostRepository == null)
                {
                    return _flightCostRepository = new FlightCostRepository(Context);
                }
                return _flightCostRepository;
            }
        }

        private ILegRepository _legRepository;

        public ILegRepository LegRepository
        {
            get
            {
                if (_legRepository == null)
                {
                    return _legRepository = new LegRepository(Context);
                }
                return _legRepository;
            }
        }

        private IFlightScheduleManager _flightManager;

        public IFlightScheduleManager FlightManager
        {
            get
            {
                if (_flightManager == null)
                {
                    return _flightManager =
                        new FlightScheduleManager(LegRepository, FlightScheduleRepository, FlightCostRepository);
                }
                return _flightManager;
            }
        }
        [Test]
        public async Task FlightManger_GetScheduleDetail_ScheduleIsExisted()
        {
            // Arrange
            const int originId = 9;
            const int destinationId = 12;
            var departureDate = DateTime.Parse("10/25/2018");

            // Act
            var schedules = await FlightManager.GetBy(originId, destinationId, departureDate);

            // Assert
            Assert.That(schedules.Count == 1);
        }

    }
}
