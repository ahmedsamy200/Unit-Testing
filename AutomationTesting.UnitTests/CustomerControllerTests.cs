using NUnit.Framework;
using AutomationTesting.Fundamentals;


namespace AutomationTesting.UnitTests
{
    [TestFixture]
    class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(0);
            //type should be NotFount
            Assert.That(result, Is.TypeOf<NotFound>());
            // or 
            //type should be NotFount or one of its derivatives
            //Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdNotZero_ReturnNotFound()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(10);
            //type should be NotFount
            Assert.That(result, Is.TypeOf<Ok>());
            // or 
            //type should be NotFount or one of its derivatives
            //Assert.That(result, Is.InstanceOf<Ok>());
        }
    }
}
