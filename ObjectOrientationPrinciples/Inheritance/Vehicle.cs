namespace ObjectOrientationPrinciples.Inheritance
{
    public class Vehicle
    {
        public string Color { get; set; }
        public int NumberOfWheels { get; set; }

        public virtual string WhatAmI()
        {
            return string.Format("I am a {0} vehicle with {1} wheels", Color, NumberOfWheels);
        }
    }
}
