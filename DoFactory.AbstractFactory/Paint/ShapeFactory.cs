namespace DoFactory.AbstractFactory.Paint
{
    using DoFactory.AbstractFactory.Paint.Colors;
    using Paint.Shapes;

    public class ShapeFactory : PaintAbstractFactory
    {
        public override Colors.Color CreateColor(string color)
        {
            return null;
        }

        public override Shape CreateShape(string shape)
        {
            shape = shape.ToUpper();

            switch (shape)
            {
                case "RECTANGLE":
                    return new Shapes.Rectangle();
                case "CIRCLE":
                    return new Shapes.Circle();
                case "SQUARE":
                    return new Shapes.Square();
                default:
                    break;
            }
            return null;
        }
    }
}
