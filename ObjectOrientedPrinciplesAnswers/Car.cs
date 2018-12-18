namespace ObjectOrientedPrinciplesAnswers
{
    public class Car : Vehicle
    {
        public int NumberOfCylinders { get; set; }

        public string PrintInfo()
        {
            return string.Format("I am a {0} car with {1} wheels and I have {2} cylinders", Color, NumberOfWheels, NumberOfCylinders);
        }
    }
}
