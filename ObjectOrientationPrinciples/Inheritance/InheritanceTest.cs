using NUnit.Framework;

namespace ObjectOrientationPrinciples.Inheritance
{
    [TestFixture]
    public class InheritanceTest
    {
        [Test]
        public void VehicleToStringTest()
        {
            Vehicle MyVehicle = new Vehicle
            {
                Color = "red",
                NumberOfWheels = 2
            };

            Assert.That(MyVehicle.WhatAmI(), Is.EqualTo("I am a red vehicle with 2 wheels"));
        }

        [Test]
        public void CarToStringTest()
        {
            Car MyCar = new Car
            {
                Color = "blue",
                NumberOfWheels = 4,
                HorsePower = 150
            };

            Assert.That(MyCar.WhatAmI(), Is.EqualTo("I am a blue vehicle with 4 wheels and a power of 150 bhp"));
        }
    }
}
