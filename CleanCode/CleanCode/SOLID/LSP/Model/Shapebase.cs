using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.SOLID.LSP.Model
{
    abstract class ShapeBase
    {
        protected double Width = 0;
        protected double Heigth = 0;

        abstract public double GetArea();

        public Drawable Render(double area)
        {
            // ...
            return new Drawable();
        }

        
    }
}
