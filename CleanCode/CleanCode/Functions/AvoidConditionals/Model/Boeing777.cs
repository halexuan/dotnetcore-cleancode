using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.Functions.AvoidConditionals.Model
{
    class Boeing777 : IAirplane
    {
        public double GetCruisingAltitude()
        {
            return GetMaxAltitude() - GetPassagerCount();
        }

        private int GetMaxAltitude()
        {
            throw new NotImplementedException();
        }

        private int GetPassagerCount()
        {
            throw new NotImplementedException();
        }
    }
}
