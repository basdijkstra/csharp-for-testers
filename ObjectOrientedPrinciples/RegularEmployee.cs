namespace ObjectOrientedPrinciples
{
    public class RegularEmployee : EmployeeTemplate
    {
        public override int CalculateSalary()
        {
            return PaidPerHour * WorkingHours;
        }
    }
}
