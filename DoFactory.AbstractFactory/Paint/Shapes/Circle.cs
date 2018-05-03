using System.Diagnostics;

namespace DoFactory.AbstractFactory.Paint.Shapes
{
    class Circle : IShape
    {
        public void Draw()
        {
            Debug.WriteLine("Circle has drawed");
        }
    }
}
