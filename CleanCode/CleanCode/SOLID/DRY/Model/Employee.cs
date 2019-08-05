using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.SOLID.DRY.Model
{
    abstract class Employee
    {
        public string Name { get; set; }
        public int Experience { get; set; }
        public double Salary { get; set; }
        public string GithubLink { get; set; }

        public abstract double CalculateExpectedSalary();

        public IEnumerable<string> Values()
        {
            yield return Name;
            yield return Experience.ToString();
            yield return Salary.ToString();
            yield return GithubLink;
        }
    }
}
