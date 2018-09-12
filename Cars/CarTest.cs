using NUnit.Framework;

namespace Cars
{
    [TestFixture]
    class CarTest
    {
        [Test]
        public void IsItalianTestPositive()
        {
            // Arrange - create a new instance of the Car object
            //           with specific property values
            Car myCar = new Car("Maserati", "Ghibli", "black");

            // Act - invoke the method to be tested
            bool isItalian = myCar.IsItalian();

            // Assert - check that the result of the method invocation
            //          matches the expected outcome
            Assert.IsTrue(isItalian);
        }

        [Test]
        public void ToStringTest()
        {
            // Arrange
            Car myCar = new Car("Alfa Romeo", "Giulia", "blue");

            // Act
            string myCarString = myCar.ToString();

            // Assert
            Assert.AreEqual(myCarString, "I am a blue Alfa Romeo Giulia");

        }
        
        [Test]
        public void IsItalianTestNegative()
        {
            // Arrange
            Car myCar = new Car("Ford", "Focus", "blue");

            // Act
            bool isItalian = myCar.IsItalian();

            // Assert
            Assert.IsFalse(isItalian);
        }

        [Test]
        public void PaintJobTest()
        {
            // Arrange
            Car myCar = new Car("Maserati", "Ghibli", "green");

            // Act
            myCar.PaintCar("blue");

            // Assert
            Assert.AreEqual("blue", myCar.Color);
        }
    }
}
