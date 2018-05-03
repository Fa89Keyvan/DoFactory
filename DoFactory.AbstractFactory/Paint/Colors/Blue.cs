using System.Diagnostics;

namespace DoFactory.AbstractFactory.Paint.Colors
{
    class Blue : Color
    {
        public override void Fill()
        {
            Debug.WriteLine("Fill with blue color");
        }
    }
}
