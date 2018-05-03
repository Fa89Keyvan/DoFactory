using System.Diagnostics;

namespace DoFactory.AbstractFactory.Paint.Shapes
{
    class Square : IShape
    {
        public void Draw()
        {
            Debug.WriteLine("Square has drawed");
        }
    }
}
