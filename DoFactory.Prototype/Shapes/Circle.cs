using System.Diagnostics;

namespace DoFactory.Prototype.Shapes
{
    public class Circle : Shape
    {

        public Circle()
        {
            this._type = "Circle";
        }

        public override void Draw() => Debug.WriteLine("Inside Circle::draw() method.");
    }
}
