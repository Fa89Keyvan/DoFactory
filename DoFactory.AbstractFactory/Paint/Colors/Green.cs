using System.Diagnostics;

namespace DoFactory.AbstractFactory.Paint.Colors
{
    public class Green : IColor
    {
        public void Fill()
        {
            Debug.WriteLine("Fill with green color");
        }
    }
}
