using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.SOLID.DRY.Model
{
    class Developer : Employee
    {
        public override double CalculateExpectedSalary()
        {
            return Salary * 1.5;
        }
    }
}
