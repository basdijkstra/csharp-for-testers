using NUnit.Framework;

namespace Books
{
    [TestFixture]
    class MagazineTest
    {
        [Test]
        public void AdvertisementTest()
        {
            // Arrange - create a new magazine instance
            Magazine a = new Magazine("Running Weekly", PublicationFrequency.Weekly, true, true);

            // Act and assert
            Assert.That(a.ICanAdvertiseInThisMagazine(), Is.True);
        }

        [Test]
        public void AnotherAdvertisementTest()
        {
            // Arrange - create a new magazine instance
            Magazine b = new Magazine("Running Weekly", PublicationFrequency.Weekly, true, true);

            // Act
            b.DiscontinueMagazine();

            // Assert
            Assert.IsFalse(b.ICanAdvertiseInThisMagazine());
        }

        [Test]
        public void AnotherTest()
        {
            Magazine c = new Magazine("Running Weekly", PublicationFrequency.Weekly, true, true);

            c.ChangePublicationFrequencyTo(PublicationFrequency.Monthly);

            Assert.IsTrue(c.IsAMonthlyMagazine());
        }
    }
}
