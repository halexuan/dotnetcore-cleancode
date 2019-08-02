using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.SOLID.LSP.Model
{
    class ShapeBase
    {
        protected double Width = 0;
        protected double Height = 0;

        abstract public double GetArea();

        
    }
}
