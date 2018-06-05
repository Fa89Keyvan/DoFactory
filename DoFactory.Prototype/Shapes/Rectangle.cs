using System.Diagnostics;

namespace DoFactory.Prototype.Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            this._type = "Rectangle";
        }

        public override void Draw() => Debug.WriteLine("Inside Rectangle::draw() method.");

    }
}
