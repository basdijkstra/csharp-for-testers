using NUnit.Framework;
using System;

namespace UnitTestRecapAnswers
{
    [TestFixture]
    public class AlbumTest
    {
        [Test]
        public void RereleaseTest()
        {
            Album album = new Album();

            album.RereleaseAlbum();

            Assert.That(album.ReleaseYear, Is.EqualTo(DateTime.Now.Year));
        }

        [Test]
        public void IsA21stCenturyAlbumTest()
        {
            Album album = new Album("My album", "My artist", 60, DateTime.Now.Year);

            Assert.That(album.IsA21stCenturyAlbum(), Is.True);
        }
    }
}
