using CleanCode.SOLID.DIP.Model.ApplicationLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.SOLID.DIP.Model.ApplicationLayer
{
    class Manager
    {
        private readonly IEnumerable<IEmployee> _employees;

        public Manager(IEnumerable<IEmployee> employees)
        {
            _employees = employees;
        }

        public void Manage()
        {
            foreach (var employee in _employees)
            {
                employee.Work();
            }
        }

    }
}
