using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.Functions.AvoidConditionals.Model
{
    class AirForceOne : IAirplane
    {
        public double GetCruisingAltitude()
        {
            return GetMaxAltitude();
        }

        private double GetMaxAltitude()
        {
            throw new NotImplementedException();
        }
    }
}
