using AutomationTesting.Fundamentals;
using NUnit.Framework;
using System.Linq;

namespace AutomationTesting.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            //var math = new Math();
            //var result = math.Add(5, 5);
            var result = _math.Add(5, 5);
            Assert.That(result, Is.EqualTo(10));
            //Assert.AreEqual(result, 10);
        }

        [Test]
        [TestCase(5 , 10 , 10)]
        [TestCase(10, 5, 10)]
        [TestCase(5, 5, 5)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a , int b , int expectedResult)
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }


        //[Test]
        //public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        //{
        //    var math = new Math();
        //    var result = math.Max(5, 10);
        //    Assert.That(result, Is.EqualTo(10));
        //}

        //[Test]
        //public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        //{
        //    var math = new Math();
        //    var result = math.Max(5, 5);
        //    Assert.That(result, Is.EqualTo(5));
        //}

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            
            var result = _math.GetOddNumbers(5);

            // general ways
            //Assert.That(result, Is.Not.Empty);
            //Assert.That(result.Count(), Is.EqualTo(3));
            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(2));
            //Assert.That(result, Does.Contain(3));

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

            //Assert.That(result, Is.Ordered);
            //Assert.That(result, Is.Unique);
        }
    }
}
