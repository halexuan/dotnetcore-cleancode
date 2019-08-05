using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.Functions.AvoidConditionals.Model
{
    class Cessna : IAirplane
    {
        public double GetCruisingAltitude()
        {
            return GetMaxAltitude() - GetFullExpenditure();
        }

        private int GetMaxAltitude()
        {
            throw new NotImplementedException();
        }

        private int GetFullExpenditure()
        {
            throw new NotImplementedException();
        }
    }
}
