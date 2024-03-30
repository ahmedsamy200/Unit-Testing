using AutomationTesting.Fundamentals;
using NUnit.Framework;

namespace AutomationTesting.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_EncloseTheStringWithStrongElement()
        {
            var Formatter = new HtmlFormatter();
            var result = Formatter.FormatAsBold("Hello");

            // specific
           // Assert.That(result, Is.EqualTo("<strong>Hello</strong>").IgnoreCase);

            // more general
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("Hello"));

        }
    }
}
