using NUnit.Framework;

namespace Books
{
    [TestFixture]
    class BookAssertionsTest
    {
        [Test]
        public void ClassicEqualAssertion()
        {
            Book myBook = new Book();

            myBook.SetGhostWriter("Ghost Writer");

            // Controleer dat de auteur van het boek gelijk is aan 'Ghost Writer'
            // Gebruik een classic assertion
        }

        [Test]
        public void ConstraintTrueAssertion()
        {
            Book myBook = new Book();

            myBook.ArtificiallyIncreaseValue();

            // Controleer dat het boek een eerste editie is
            // Gebruik een constraint model-assertion
        }

        [Test]
        public void ConstraintGreaterThanAssertion()
        {
            Book myBook = new Book("Catcher in the rye", "J.D. Salinger", 1951, false);

            // Controleer dat het boek is geschreven in na 1900
            // Gebruik een constraint model-assertion
        }
    }
}