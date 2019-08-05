using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.SOLID.ISP.Model
{
    class Human : IEmployee
    {
        public void Eat()
        {
            // ... eating in lunch break
        }

        public void Work()
        {
            // ... working
        }
    }
}
