namespace ObjectOrientedPrinciples
{
    public class CLevelEmployee : EmployeeTemplate
    {
        public override int CalculateSalary()
        {
            return PaidPerHour * WorkingHours + 1000;
        }
    }
}
