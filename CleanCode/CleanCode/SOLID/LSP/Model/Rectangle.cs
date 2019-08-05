using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.SOLID.LSP.Model
{
    class Rectangle : ShapeBase
    {
        public void SetWidth(double width)
        {
            Width = width;
        }

        public void SetHeight(double heigth)
        {
            Heigth = heigth;
        }

        public override double GetArea()
        {
            return Width * Heigth;
        }
    }
}
