

using MarisNew;
using static MarisNew.Reservation;

namespace Test.UnitTests
{
    public class ReservationTests
    {
        [Fact]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            //Arange
            var reservation = new Reservation();
            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
           //Assert
           Assert.True(result);
        }

        [Fact]
        public static void CanBeCancelledBy_SameUSerCancelling_ReturnsTrue()
        {
            var user = new User();
            var reservation = new Reservation { MadeBy = user };
            var result = reservation.CanBeCancelledBy(user);
            Assert.True(result);
        }

        [Fact]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnFalse()
        {
            var reservation = new Reservation { MadeBy = new User() };
            var result = reservation.CanBeCancelledBy(new User());
            Assert.False(result);
        }
    }

    public class ConvertTests
    {
        [Fact]
        public void TestF2C()
        {
            double F = 32;
            double C = 0;
            double rvalue = MarisNew.Converts.F2c(F);
            Assert.Equal(C, rvalue);
            Assert.Equal(100, MarisNew.Converts.F2c(212));
        }
        [Fact]
        public void TestC2F()
        {
            Assert.Equal(212, MarisNew.Converts.C2f(100));
        }
    }

}   