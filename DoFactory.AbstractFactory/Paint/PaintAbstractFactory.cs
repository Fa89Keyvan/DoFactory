using DoFactory.AbstractFactory.Paint.Shapes;
using System.Drawing;

namespace DoFactory.AbstractFactory.Paint
{
    public abstract class PaintAbstractFactory
    {
        public abstract Colors.Color CreateColor(string color);
        public abstract Shape CreateShape(string shape);
    }
}
