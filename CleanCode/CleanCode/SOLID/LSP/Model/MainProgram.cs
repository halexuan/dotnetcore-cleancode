using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.SOLID.LSP.Model
{
    class MainProgram
    {
        static void _Main(string[] args)
        {
            var shapes = new ShapeBase[] { new Rectangle(), new Rectangle(), new Square() };
            RenderLargeRectangles(shapes);
            Console.ReadKey();
        }

        static Drawable RenderLargeRectangles(ShapeBase[] rectangles)
        {
            foreach (ShapeBase rectangle in rectangles)
            {
                if (rectangle is Square)
                {
                    ((Square)rectangle).SetLength(5);
                }
                else if (rectangle is Rectangle)
                {
                    ((Rectangle)rectangle).SetWidth(4);
                    ((Rectangle)rectangle).SetHeight(5);
                }

                var area = rectangle.GetArea();
                rectangle.Render(area);
                Console.WriteLine("Area = " + area + " Type = " + rectangle.GetType());
            }

            return null;
        }
    }
}
