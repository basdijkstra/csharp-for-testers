namespace ObjectOrientationPrinciples.Abstraction
{
    public class RegularEmployee : Employee
    {
        public override int CalculateSalary()
        {
            return PaidPerHour * WorkingHours;
        }
    }
}
