namespace DoFactory.AbstractFactory.Paint
{
    public class PaintFactoryProducer
    {
        public static PaintAbstractFactory GetPaintFactory(string factoryType)
        {
            factoryType = factoryType.ToUpper();

            switch (factoryType)
            {
                case "SHAPE":
                    return new ShapeFactory();
                case "COLOR":
                    return new ColorFactory();
                default:
                    break;
            }
            return null;
        }
    }
}
