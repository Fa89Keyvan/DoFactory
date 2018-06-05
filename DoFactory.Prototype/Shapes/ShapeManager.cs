using System.Collections.Generic;

namespace DoFactory.Prototype.Shapes
{
    class ShapeManager
    {
        private static Dictionary<string, Shape> _shapes = new Dictionary<string, Shape>();

        public static Shape GetShape(string shapeId)
        {
            Shape shape = _shapes[shapeId];
            return shape.clone() as Shape;
        }

        // for each shape run database query and create shape
        // shapeMap.put(shapeKey, shape);
        // for example, we are adding three shapes
   
        public static void loadCache() {
            Circle circle = new Circle();
            circle.setId("1");
            _shapes[circle.getId()] = circle;

            Square square = new Square();
            square.setId("2");
            _shapes[square.getId()] = square;

            Rectangle rectangle = new Rectangle();
            rectangle.setId("3");
            _shapes[rectangle.getId()] = rectangle;
        }
    }
}
