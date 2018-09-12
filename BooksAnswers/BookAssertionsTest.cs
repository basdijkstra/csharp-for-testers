using NUnit.Framework;

namespace BooksAnswers
{
    [TestFixture]
    class BookAssertionsTest
    {
        [Test]
        public void ClassicEqualAssertion()
        {
            Book myBook = new Book("Catcher in the rye", "J.D. Salinger", 1951, false);

            myBook.SetGhostWriter("Ghost Writer");

            // Controleer dat de auteur van het boek gelijk is aan 'Ghost Writer'
            // Gebruik een classic assertion
            Assert.AreEqual("Ghost Writer", myBook.Author);
        }

        [Test]
        public void ConstraintTrueAssertion()
        {
            Book myBook = new Book("Catcher in the rye", "J.D. Salinger", 1951, false);

            myBook.ArtificiallyIncreaseValue();

            // Controleer dat het boek een eerste editie is
            // Gebruik een constraint model-assertion
            Assert.That(myBook.IsFirstEdition, Is.True);
        }

        [Test]
        public void ConstraintGreaterThanAssertion()
        {
            Book myBook = new Book("Catcher in the rye", "J.D. Salinger", 1951, false);

            // Controleer dat het boek is geschreven in na 1900
            // Gebruik een constraint model-assertion
            Assert.That(myBook.YearPublished, Is.GreaterThan(1900));
        }
    }
}
