using NUnit.Framework;

namespace BooksAnswers
{
    [TestFixture]
    class MagazineTest
    {
        Magazine myMagazine;

        [SetUp]
        public void CreateTestData()
        {
            myMagazine = new Magazine("Running Weekly", PublicationFrequency.Weekly, true, true);
        }

        [Test]
        public void ICanAdvertiseInARunningMagazineThatAllowsAdsTest()
        {
            // Act and assert
            Assert.That(myMagazine.ICanAdvertiseInThisMagazine(), Is.True);
        }

        [Test]
        public void ICannotAdvertiseInADiscontinuedMagazineTest()
        {
            // Act
            myMagazine.DiscontinueMagazine();

            // Assert
            Assert.IsFalse(myMagazine.ICanAdvertiseInThisMagazine());
        }

        [Test]
        public void ICanChangeThePublicationFrequencyToMonthlyTest()
        {
            myMagazine.ChangePublicationFrequencyTo(PublicationFrequency.Monthly);

            Assert.IsTrue(myMagazine.IsAMonthlyMagazine());
        }
    }
}
