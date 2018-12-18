using NUnit.Framework;

namespace RefresherAnswers
{
    [TestFixture]
    public class AddressTest
    {
        [Test]
        public void MoveOneAddressToTheRightTest()
        {
            Address address = new Address();

            address.MoveOneHouseToTheRight();

            Assert.That(address.HouseNumber, Is.EqualTo(3));
        }
    }
}
