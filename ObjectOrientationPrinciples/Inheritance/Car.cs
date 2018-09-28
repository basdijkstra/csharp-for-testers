namespace ObjectOrientationPrinciples.Inheritance
{
    public class Car : Vehicle
    {
        public int HorsePower { get; set; }

        public override string WhatAmI()
        {
            return string.Format("I am a {0} vehicle with {1} wheels and a power of {2} bhp", Color, NumberOfWheels, HorsePower);
        }
    }
}
