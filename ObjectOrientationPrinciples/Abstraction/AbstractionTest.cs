using NUnit.Framework;

namespace ObjectOrientationPrinciples.Abstraction
{
    [TestFixture]
    public class AbstractionTest
    {
        [Test]
        public void RegularEmployeeSalaryTest()
        {
            Employee RegularEmp = new RegularEmployee
            {
                PaidPerHour = 75,
                WorkingHours = 40
            };

            Assert.That(RegularEmp.CalculateSalary(), Is.EqualTo(3000));
        }

        [Test]
        public void CLevelEmployeeSalaryTest()
        {
            Employee CLevelEmp = new CLevelEmployee
            {
                PaidPerHour = 75,
                WorkingHours = 40
        };

            Assert.That(CLevelEmp.CalculateSalary(), Is.EqualTo(13000));
        }
    }
}
