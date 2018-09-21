namespace ObjectOrientationPrinciples.Abstraction
{
    public abstract class Employee
    {
        public int PaidPerHour { get; set; }
        public int WorkingHours { get; set; }

        public abstract int CalculateSalary();
    }
}
