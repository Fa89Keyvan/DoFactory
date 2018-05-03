using DoFactory.AbstractFactory.Paint.Colors;
using DoFactory.AbstractFactory.Paint.Shapes;

namespace DoFactory.AbstractFactory.Paint
{
    class ColorFactory : PaintAbstractFactory
    {
        public override IColor CreateColor(string color)
        {
            color = color.ToUpper();

            switch (color)
            {
                case "RED":
                    return new Red();
                case "GREEN":
                    return new Green();
                case "BLUE":
                    return new Blue();
                default:
                    break;
            }
            return null;
        }

        public override IShape CreateShape(string shape)
        {
            return null;
        }
    }
}
