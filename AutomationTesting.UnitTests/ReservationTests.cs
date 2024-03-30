using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationTesting.Fundamentals;

namespace AutomationTesting.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //arrange
            Reservation reservation = new Reservation();

            //act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true});

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnsTrue()
        {
            User user = new User();
            Reservation reservation = new Reservation() { MadeBy = user};
 
            var result = reservation.CanBeCancelledBy(user);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCancellingTheReservation_ReturnsFalse()
        {
            Reservation reservation = new Reservation() { MadeBy = new User() };

            var result = reservation.CanBeCancelledBy(new User());

            Assert.IsFalse(result);
        }
    }

}
