using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.SOLID.DRY.Model
{
    class Manager : Employee
    {
        public override double CalculateExpectedSalary()
        {
            return Salary * 2;
        }
    }
}
