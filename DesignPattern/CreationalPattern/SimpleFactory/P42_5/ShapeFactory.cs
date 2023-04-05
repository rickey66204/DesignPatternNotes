using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPattern.SimpleFactory.P42_5
{
    internal class ShapeFactory
    {
        public static Shape CreateShape(ShapeType type)
        {
            switch (type)
            {
                case ShapeType.Circle:
                    return new Circle();
                case ShapeType.Rectangle:
                    return new Rectangle();
                case ShapeType.Triangle:
                    return new Triangle();
                default:
                    throw new UnSupportedShapeException();
            }
        }
    }

    internal class UnSupportedShapeException : NotSupportedException
    {

    }

    internal enum ShapeType
    {
        Circle,
        Rectangle,
        Triangle,
    }
}
