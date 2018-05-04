using System;

namespace DoFactory.FactoryMethod.Shapes
{
    class ShapeFactory
    {
        public Shape CreateShape(ShapeTypes shapeType)
        {
            switch (shapeType)
            {
                case ShapeTypes.Rectangle: return new Rectangle();
                case ShapeTypes.Square:    return new Square();
                case ShapeTypes.Circle:    return new Circle();
                default: throw new Exception("invalid shapeType");
            }
        }
    }
}
