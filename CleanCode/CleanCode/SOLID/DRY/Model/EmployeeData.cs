using System;

namespace CleanCode.SOLID.DRY.Model
{
    class EmployeeData
    {
        protected string Data;

        public void SetData(string data)
        {
            Data = data;
        }
    }
}