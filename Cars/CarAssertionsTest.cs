using NUnit.Framework;

namespace Cars
{
    [TestFixture]
    class CarAssertionsTest
    {
        [Test]
        public void ClassicEqualAssertion()
        {
            Car myCar = new Car("Lancia", "Delta", "black");

            myCar.PaintCar("blue");

            Assert.AreEqual("blue", myCar.Color);
        }

        [Test]
        public void ConstraintEqualAssertion()
        {
            Car myCar = new Car("Lancia", "Delta", "black");

            myCar.PaintCar("red");

            Assert.That(myCar.Color, Is.EqualTo("red"));
        }

        [Test]
        public void ClassicTrueAssertion()
        {
            Car myCar = new Car("Lancia", "Delta", "black");

            Assert.IsTrue(myCar.IsItalian());
        }

        [Test]
        public void ConstraintTrueAssertion()
        {
            Car myCar = new Car("Ferrari", "F40", "red");

            Assert.That(myCar.IsItalian(), Is.True);
        }

        [Test]
        public void ConstraintArrayContentsAssertion()
        {
            int[] arrayInts = new int[] { 1, 2, 3, 4 };

            Assert.That(arrayInts, Has.Exactly(1).EqualTo(3));
            Assert.That(arrayInts, Has.Exactly(2).GreaterThan(2));
        }
    }
}
