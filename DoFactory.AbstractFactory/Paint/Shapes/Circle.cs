using System.Diagnostics;

namespace DoFactory.AbstractFactory.Paint.Shapes
{
    class Circle : Shape
    {
        public override void Draw()
        {
            Debug.WriteLine("Circle has drawed");
        }
    }
}
