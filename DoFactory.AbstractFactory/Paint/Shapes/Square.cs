using System.Diagnostics;

namespace DoFactory.AbstractFactory.Paint.Shapes
{
    class Square : Shape
    {
        public override void Draw()
        {
            Debug.WriteLine("Square has drawed");
        }
    }
}
