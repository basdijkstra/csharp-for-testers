namespace ObjectOrientationPrinciples.Abstraction
{
    public class RegularEmployee : Employee
    {
        public override int CalculateSalary()
        {
            return this.PaidPerHour * this.WorkingHours;
        }
    }
}
