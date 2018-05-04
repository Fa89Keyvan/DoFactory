using System.Diagnostics;

namespace DoFactory.FactoryMethod.Shapes
{
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Debug.WriteLine("Rectangle has drawed");
        }
    }
}
