namespace ObjectOrientedPrinciples
{
    public class Employee : Person
    {
        public int EmployeeId { get; set; }
        public int Salary { get; set; }

        public string PrintInfo()
        {
            return string.Format("{0} is {1} years old. " +
                "Their employee ID is {2} and they make ${3} per year",
                Name, Age, EmployeeId, Salary);
        }
    }
}
