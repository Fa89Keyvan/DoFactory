using System.Diagnostics;

namespace DoFactory.AbstractFactory.Paint.Colors
{
    public class Green : Color
    {
        public override void Fill()
        {
            Debug.WriteLine("Fill with green color");
        }
    }
}
