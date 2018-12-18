namespace ObjectOrientedPrinciples
{
    public abstract class EmployeeTemplate
    {
        public int PaidPerHour { get; set; }
        public int WorkingHours { get; set; }

        public abstract int CalculateSalary();
    }
}
