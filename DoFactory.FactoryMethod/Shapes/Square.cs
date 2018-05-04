using System.Diagnostics;

namespace DoFactory.FactoryMethod.Shapes
{
    class Square : Shape
    {
        public override void Draw()
        {
            Debug.WriteLine("Square has drawed");
        }
    }
}
