using System.Diagnostics;

namespace DoFactory.AbstractFactory.Paint.Colors
{
    public class Red : IColor
    {
        public void Fill()
        {
            Debug.WriteLine("Fill with Red color");
        }
    }
}
