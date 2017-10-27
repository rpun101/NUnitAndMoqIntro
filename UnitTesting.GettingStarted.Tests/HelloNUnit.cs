
using NUnit.Framework;

namespace UnitTesting.GettingStarted.Tests
{
    [TestFixture]
    public class HelloNUnit
    {

        [Test]
        public void TestHelloNUnit()  //method or class name does not need to have Test* in it, but attribute is required
        {
            //Assert.That({acutal value from operation}, {expected value});
            Assert.That(true, Is.True);
        }
    }


}
