using System.Diagnostics;

namespace DoFactory.AbstractFactory.Paint.Shapes
{
    class Rectangle : IShape
    {
        public void Draw()
        {
            Debug.WriteLine("Rectangle has drawed");
        }
    }
}
 