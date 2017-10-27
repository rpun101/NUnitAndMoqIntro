
using NUnit.Framework;

namespace UnitTesting.GettingStarted.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_Always_ReturnsExpectedResult()  //[subject]_[scenario]_[result] i.e GrantLoan_WhenCreditLessthan500_ReturnsFalse
        {
            var systemUnderTest = new Calculator();
            Assert.That(systemUnderTest.Add(1, 3), Is.EqualTo(4));
        }

        [TestCase(1,2)]
        [TestCase(0,9)]
        [TestCase(100003, 349029)]
        public void Add_Always_ReturnsExpectedResult_WithTestCaseExample(int lhs, int rhs)
        {
            var systemUnderTest = new Calculator();
            var expectedValue = lhs + rhs;
            Assert.That(systemUnderTest.Add(lhs, rhs), Is.EqualTo(expectedValue));
        }
    }
}
