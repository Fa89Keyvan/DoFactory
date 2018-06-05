using System.Diagnostics;

namespace DoFactory.Prototype.Shapes
{
    public class Square : Shape
    {

        public Square()
        {
            this._type = "Square";
        }

        public override void Draw() => Debug.WriteLine("Inside Square::draw() method.");
    }
}
