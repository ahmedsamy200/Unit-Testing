using NUnit.Framework;
using AutomationTesting.Fundamentals;

namespace AutomationTesting.UnitTests
{
    [TestFixture]
    class DemeritPointsCalculatorTests
    {
        [Test]
        public void CalculateDemeritPoints_SpeedLessThanZeroOrMoreThanMaxSpeed_ThrowArgumentOutOfRangeException()
        {
            DemeritPointsCalculator calculator = new DemeritPointsCalculator();
            Assert.That(() => calculator.CalculateDemeritPoints(-10) , Throws.Exception);
        } 
    }
}
