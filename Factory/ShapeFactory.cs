using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public  class ShapeFactory
    {
        public static IShape? GetShape(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.Rectangle:
                    return new Rectangle();
                case ShapeType.Square:
                    return new Square();
                case ShapeType.Circle:
                    return new Circle();
                default:
                    return null;
            }
        } 
    }
}
 