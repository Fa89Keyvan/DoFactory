using System.Diagnostics;

namespace DoFactory.AbstractFactory.Paint.Shapes
{
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Debug.WriteLine("Rectangle has drawed");
        }
    }
}
 