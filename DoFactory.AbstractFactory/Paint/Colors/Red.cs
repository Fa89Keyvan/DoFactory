using System.Diagnostics;

namespace DoFactory.AbstractFactory.Paint.Colors
{
    public class Red : Color
    {
        public override void Fill()
        {
            Debug.WriteLine("Fill with Red color");
        }
    }
}
