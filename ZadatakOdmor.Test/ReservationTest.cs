using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZadatakOdmor.Test
{
    [TestClass]
    public class ReservationTest
    {
        private Accommodation _accommodation;
        private AccommodationManagement _accommodationManagement;

        [TestInitialize]
        public void TestInit()
        {
            //prepare test data
            _accommodationManagement = new AccommodationManagement();
            _accommodation = new Accommodation("test accomodation", 34, "test city", Places.CrnaGora);
            _accommodationManagement.CreateNewAccomodation(_accommodation);
            var reservation = new Reservation(_accommodation, new DateTime(2021, 08, 08),
                new DateTime(2021, 08, 09), "test user");
            var reservation2 = new Reservation(_accommodation, new DateTime(2021, 08, 10),
                new DateTime(2021, 08, 15), "test user");
            var reservation3 = new Reservation(_accommodation, new DateTime(2021, 09, 08),
                new DateTime(2021, 09, 09), "test user");
            var reservation4 = new Reservation(_accommodation, new DateTime(2021, 10, 08),
                new DateTime(2021, 10, 09), "test user");
            var reservation5 = new Reservation(_accommodation, new DateTime(2021, 10, 15),
                new DateTime(2021, 10, 20), "test user");
            _accommodationManagement.MakeReservation(reservation);
            _accommodationManagement.MakeReservation(reservation2);
            _accommodationManagement.MakeReservation(reservation3);
            _accommodationManagement.MakeReservation(reservation4);
            _accommodationManagement.MakeReservation(reservation5);
        }

        [TestMethod]
        public void ReservationTest_False_WhenSame()
        {
            Assert.IsFalse(_accommodationManagement.CheckIfAvailable(_accommodation, new DateTime(2021, 08, 08),
                new DateTime(2021, 08, 09)));
        }

        [TestMethod]
        public void ReservationTest_False_WhenSameStartDate()
        {
            Assert.IsFalse(_accommodationManagement.CheckIfAvailable(_accommodation, new DateTime(2021, 08, 08),
                new DateTime(2021, 08, 10)));
        }

        [TestMethod]
        public void ReservationTest_True_WhenSameStartDate()
        {
            Assert.IsFalse(_accommodationManagement.CheckIfAvailable(_accommodation, new DateTime(2021, 08, 09),
                new DateTime(2021, 08, 10)));
        }

        [TestMethod]
        public void ReservationTest_True_WhenBefore()
        {
            Assert.IsTrue(_accommodationManagement.CheckIfAvailable(_accommodation, new DateTime(2021, 06, 08),
                new DateTime(2021, 07, 09)));
        }

        [TestMethod]
        public void ReservationTest_True_WhenAfter()
        {
            Assert.IsTrue(_accommodationManagement.CheckIfAvailable(_accommodation, new DateTime(2022, 08, 08),
                new DateTime(2022, 08, 09)));
        }

        [TestMethod]
        public void ReservationTest_True_WhenMiddle()
        {
            Assert.IsTrue(_accommodationManagement.CheckIfAvailable(_accommodation, new DateTime(2021, 08, 17),
                new DateTime(2021, 08, 22)));
        }
    }
}