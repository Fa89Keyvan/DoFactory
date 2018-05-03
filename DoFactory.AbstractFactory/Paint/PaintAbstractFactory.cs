using DoFactory.AbstractFactory.Paint.Colors;
using DoFactory.AbstractFactory.Paint.Shapes;
using System.Drawing;

namespace DoFactory.AbstractFactory.Paint
{
    public abstract class PaintAbstractFactory
    {
        public abstract IColor CreateColor(string color);
        public abstract IShape CreateShape(string shape);
    }
}
