﻿namespace ObjectOrientationPrinciples.Abstraction
{
    public class CLevelEmployee : Employee
    {
        private readonly int BONUS = 10000;

        public override int CalculateSalary()
        {
            return this.PaidPerHour * this.WorkingHours + BONUS;
        }
    }
}
