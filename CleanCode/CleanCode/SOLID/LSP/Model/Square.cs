using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.SOLID.LSP.Model
{
    class Square : ShapeBase
    {
        private double Length = 0;

        public void SetLength(double length)
        {
            Length = length;
        }

        public override double GetArea()
        {
            return Math.Pow(Length, 2);
        }
    }
}
